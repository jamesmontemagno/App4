using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public List<Customer> MyList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MyList = new List<Customer>
            {
                new Customer { Name = "James", Details = "James Details"},
                new Customer { Name = "Harshith", Details = "Harshith Details"}

            };
            BindingContext = this;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
