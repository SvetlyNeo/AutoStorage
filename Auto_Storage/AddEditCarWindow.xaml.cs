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
using System.Windows.Shapes;
using System.Globalization;
using Auto_Storage.AutoContext;
using System.Data.Entity;

namespace Auto_Storage
{
    public partial class AddEditCarWindow : Window
    {
        private Car _car;
        public AddEditCarWindow()
        {
            InitializeComponent();
            
            using (AutoStorageContext db = new AutoStorageContext())
            {
                db.Manufacturers.Load();
                cbAddManuf.ItemsSource = db.Manufacturers.Local.Select(m => m).Where(m => m.Id != 1);

                db.Marks.Load();
                cbAddMark.ItemsSource = db.Marks.Local.Select(m => m).Where(m => m.Id != 1);
            }

            Title = "Добавление нового автомобиля";
            addEditCarButton.Content = "Добавить";
            Show();

            addEditCarButton.Click += AddCarButton_Click;
        }
        public AddEditCarWindow(Car car)
        {
            _car = car;
            InitializeComponent();

            Title = "Редактирование деталей автомобиля";
            addEditCarButton.Content = "Сохранить";
            cbAddManuf.IsEnabled = false;
            cbAddManuf.Text = car.Manufacturer.Name;
            cbAddMark.IsEnabled = false;
            cbAddMark.Text = car.Mark.Name;
            addCarModel.Text = car.Model;
            addCarPower.Text = car.Power.ToString();
            addCarAcceleration.Text = car.Acceleration.ToString();
            addCarConsumption.Text = car.Consumption.ToString();
            addCarSpeed.Text = car.MaxSpeed.ToString();
            addCarPrice.Text = car.Price.ToString();
            Show();

            addEditCarButton.Click += EditCarButton_Click;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            if (cbAddManuf.Text == "" || cbAddMark.Text == "" || addCarModel.Text == "" || addCarPower.Text == "" || addCarAcceleration.Text == "" || addCarConsumption.Text == "" || addCarSpeed.Text == "" || addCarPrice.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                Manufacturer manufacturer = new Manufacturer { Name = cbAddManuf.Text };
                Mark mark = new Mark { Name = cbAddMark.Text, Manufacturer = manufacturer };

                using (AutoStorageContext db = new AutoStorageContext())
                {
                    if (db.Manufacturers.Any(m => m.Name == cbAddManuf.Text))
                    {
                        manufacturer = db.Manufacturers.First(m => m.Name == cbAddManuf.Text);
                    }
                    else
                    {
                        db.Manufacturers.Add(manufacturer);
                    }
                    db.SaveChanges();

                    if (db.Marks.Any(m => m.Name == cbAddMark.Text))
                    {
                        mark = db.Marks.First(m => m.Name == cbAddMark.Text);
                    }
                    else
                    {
                        db.Marks.Add(mark);
                    }
                    db.SaveChanges();

                    Car car = new Car
                    {
                        Model = addCarModel.Text,
                        Power = int.Parse(addCarPower.Text),
                        Acceleration = double.Parse(addCarAcceleration.Text),
                        Consumption = double.Parse(addCarConsumption.Text),
                        MaxSpeed = int.Parse(addCarSpeed.Text),
                        Price = int.Parse(addCarPrice.Text),
                        Manufacturer = manufacturer,
                        Mark = mark
                    };
                    db.Cars.Add(car);
                    db.SaveChanges();
                }
                
                this.Close();
            }
        }

        private void EditCarButton_Click(object sender, RoutedEventArgs e)
        {
            using (AutoStorageContext db = new AutoStorageContext())
            {
                Car car = db.Cars.Find(_car.Id);
                car.Model = addCarModel.Text;
                car.Power = int.Parse(addCarPower.Text);
                car.Acceleration = double.Parse(addCarAcceleration.Text);
                car.Consumption = double.Parse(addCarConsumption.Text);
                car.MaxSpeed = int.Parse(addCarSpeed.Text);
                car.Price = int.Parse(addCarPrice.Text);
                db.SaveChanges();
            }
            this.Close();
        }

        private void addCarSpeed_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void cbAddManuf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Manufacturer manufacturer = cbAddManuf.SelectedItem as Manufacturer;

            using (AutoStorageContext db = new AutoStorageContext())
            {
                db.Manufacturers.Load();
                db.Marks.Load();
                cbAddMark.ItemsSource = db.Marks.Local.Select(m => m).Where(m => m.ManufacturerId == manufacturer.Id);
            }
        }

        private void addCarAcceleration_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!addCarAcceleration.Text.Contains(",")
               && addCarAcceleration.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void addCarConsumption_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) ||(e.Text == ",")
               && (!addCarConsumption.Text.Contains(",")
               && addCarConsumption.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
    }
}
