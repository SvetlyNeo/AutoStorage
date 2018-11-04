using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using Auto_Storage.AutoContext;

namespace Auto_Storage
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewTable();
        }

        public void ViewTable()
        {
            using (AutoStorageContext db = new AutoStorageContext())
            {
                db.Manufacturers.Load();
                cbManufacturer.ItemsSource = db.Manufacturers.ToList();
                db.Marks.Load();
                cbMark.ItemsSource = db.Marks.ToList();
                db.Cars.Load();
                carsGrid.ItemsSource = db.Cars.Local.ToBindingList();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var addCar = new AddEditCarWindow();
            this.IsEnabled = false;
            addCar.Closing += AddCar_Closing;
        }

        private void AddCar_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.IsEnabled = true;
            ViewTable();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Car car = carsGrid.SelectedItem as Car;

            using (AutoStorageContext db = new AutoStorageContext())
            {
                car = db.Cars.Find(car.Id);
                if (car != null)
                {
                    db.Cars.Remove(car);
                }

                db.SaveChanges();
            }
            ViewTable();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (carsGrid.SelectedItems.Count > 0)
            {
                Car car = carsGrid.SelectedItem as Car;
                var editCar = new AddEditCarWindow(car);

                this.IsEnabled = false;
                editCar.Closing += AddCar_Closing;
            }
        }

        private void cbManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Manufacturer manufacturer = cbManufacturer.SelectedItem as Manufacturer;

            using (AutoStorageContext db = new AutoStorageContext())
            {
                if (cbManufacturer.SelectedIndex > 0)
                {
                    db.Manufacturers.Load();
                    db.Marks.Load();
                    cbMark.ItemsSource = db.Marks.Local.Select(m => m).Where(m => m.ManufacturerId == 1 || m.ManufacturerId == manufacturer.Id);
                    db.Cars.Load();
                    carsGrid.ItemsSource = db.Cars.Local.Select(c => c).Where(c => c.ManufacturerId == manufacturer.Id);
                }
                else
                {
                    ViewTable();
                }
            }
        }

        private void cbMark_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mark mark = cbMark.SelectedItem as Mark;

            using (AutoStorageContext db = new AutoStorageContext())
            {
                if (cbMark.SelectedIndex > 0)
                {
                    db.Manufacturers.Load();
                    db.Marks.Load();
                    db.Cars.Load();
                    carsGrid.ItemsSource = db.Cars.Local.Select(c => c).Where(c => c.MarkId == mark.Id);
                }
                else
                {
                    db.Manufacturers.Load();
                    db.Marks.Load();
                    db.Cars.Load();
                    carsGrid.ItemsSource = db.Cars.Local.Select(c => c).Where(c => c.Manufacturer.Name == cbManufacturer.Text);
                }
            }
        }
    }
}
