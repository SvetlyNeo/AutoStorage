using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Auto_Storage.AutoContext
{
    class AutoStorageInitializer : DropCreateDatabaseAlways<AutoStorageContext>
    {
        protected override void Seed(AutoStorageContext db)
        {
            var all = new Manufacturer { Name = "Все" };
            var vw = new Manufacturer { Name = "Volkswagen Group" };
            var gm = new Manufacturer { Name = "General Motors" };
            var cr = new Manufacturer { Name = "Chrysler" };
            db.Manufacturers.AddRange(new List<Manufacturer> { all, vw, gm, cr });
            db.SaveChanges();

            var allM = new Mark { Name = "Все", Manufacturer = all };
            var dodge = new Mark { Name = "Dodge", Manufacturer = cr };
            var cadillac = new Mark { Name = "Cadillac", Manufacturer = gm };
            var bentley = new Mark { Name = "Bentley", Manufacturer = vw };
            var volkw = new Mark { Name = "Volkswagen", Manufacturer = vw };
            var chevrolet = new Mark { Name = "Chevrolet", Manufacturer = gm };
            var opel = new Mark { Name = "Opel", Manufacturer = gm };
            var chrysler = new Mark { Name = "Chrysler", Manufacturer = cr };
            db.Marks.AddRange(new List<Mark> { allM, dodge, cadillac, bentley, volkw, chevrolet, opel, chrysler });
            db.SaveChanges();

            var bSuper = new Car { Model = "Supersport", Power = 630, Acceleration = 3.9, Consumption = 16.7, MaxSpeed = 329, Price = 15000, Manufacturer = vw, Mark = bentley };
            var vwT = new Car { Model = "Tiguan", Power = 150, Acceleration = 9.3, Consumption = 8.4, MaxSpeed = 192, Price = 12000, Manufacturer = vw, Mark = volkw };
            var dAzure = new Car { Model = "Azure", Power = 457, Acceleration = 6, Consumption = 19.5, MaxSpeed = 270, Price = 13500, Manufacturer = vw, Mark = bentley };
            var cEsc = new Car { Model = "Escalade", Power = 409, Acceleration = 6.8, Consumption = 16.2, MaxSpeed = 170, Price = 10000, Manufacturer = gm, Mark = cadillac };
            var cImp = new Car { Model = "Impala", Power = 203, Acceleration = 8.5, Consumption = 9.1, MaxSpeed = 180, Price = 5000, Manufacturer = gm, Mark = chevrolet };
            var cOrl = new Car { Model = "Orlando", Power = 141, Acceleration = 12, Consumption = 7.8, MaxSpeed = 185, Price = 8000, Manufacturer = gm, Mark = chevrolet };
            var oAstra = new Car { Model = "Astra", Power = 115, Acceleration = 11.7, Consumption = 6.3, MaxSpeed = 188, Price = 7000, Manufacturer = gm, Mark = opel };
            var oIns = new Car { Model = "Insignia", Power = 220, Acceleration = 7.6, Consumption = 8.9, MaxSpeed = 242, Price = 14000, Manufacturer = gm, Mark = opel };
            var dViper = new Car { Model = "Viper", Power = 517, Acceleration = 3.9, Consumption = 19.4, MaxSpeed = 306, Price = 18000, Manufacturer = cr, Mark = dodge };
            var dCharger = new Car { Model = "Charger", Power = 344, Acceleration = 6, Consumption = 11.6, MaxSpeed = 250, Price = 16000, Manufacturer = cr, Mark = dodge };
            var dAvenger = new Car { Model = "Avenger", Power = 156, Acceleration = 12.1, Consumption = 7.8, MaxSpeed = 200, Price = 7500, Manufacturer = cr, Mark = dodge };
            var cConc = new Car { Model = "Concorde", Power = 253, Acceleration = 7.8, Consumption = 11.1, MaxSpeed = 225, Price = 6000, Manufacturer = cr, Mark = chrysler };
            db.Cars.AddRange(new List<Car> { bSuper, vwT, dAzure, cEsc, cImp, cOrl, oAstra, oIns, dViper, dCharger, dAvenger, cConc });
            db.SaveChanges();
        }
    }
}
