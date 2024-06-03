using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnCatalogButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CatalogPage());
        }

        private async void OnConstructorButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConstructorPage());
        }
    }
}
