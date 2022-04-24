using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNEtCore_EntityFramework_MySqlDB
{
    public partial class Form1 : Form
    {
        // Go to View -> Terminal
       // Goto project folder by terminal:- cd <project_name>
       // To Scaffolding a MySQL run follwing command with correct values
       // dotnet ef dbcontext scaffold "Server=localhost;Database=myDatabase;User=userame;Password=password;" "Pomelo.EntityFrameworkCore.MySql"
       // Ref : https://www.youtube.com/watch?v=iKSj3AyGq8w

        // .Net Version : 5.0  (.Net Core)
        // Packages Using : 
        //    Microsoft.EntityFrameworkCore.Design  5.0.11
        //    Pomelo.EntityFrameworkCore.MySql      5.0.2


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            insertNewCar();
            using (carsContext carsContext = new carsContext())
            {
                var cars = carsContext.Cars.ToList();
                var carList = new BindingList<Car>(cars);
                dataGridView1.DataSource = carList;
            }
        }

        private void insertNewCar()
        {
            Car car = new Car
            {
                CarName = "New Car",
                CarType = "type",
                Image = "aa",
                HireCost = 1000,
                Capacity = 4000,
                Status = "active",
            };
            using (carsContext carsContext = new carsContext())
            {
                var cars = carsContext.Add(car);
                carsContext.SaveChanges();
            }
        }

        private void searchCars()
        {
            using (carsContext carsContext = new carsContext())
            {
                var cars = carsContext.Cars.Select(car => car.CarName == "Mercedes Benz").ToList();

            }
        }

    }  
}
