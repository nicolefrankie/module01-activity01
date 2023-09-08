using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace module01_activity01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OpenPage1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void OpenPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
