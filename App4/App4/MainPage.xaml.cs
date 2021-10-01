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
        public List<string> MyList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MyList = new List<string> { "Code 1", "Code 2" };
            BindingContext = this;
        }
    }
}
