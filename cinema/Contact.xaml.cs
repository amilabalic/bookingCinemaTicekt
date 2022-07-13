using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinema
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }
         

       

        private async void Test_Clicked(object sender, EventArgs e)
        {
            var location = new Location(43.85062848377747, 18.355113655372655);
            var options = new MapLaunchOptions { Name = "Cineplexx Sarajevo", NavigationMode = NavigationMode.Driving };
            await Map.OpenAsync(location, options);
            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}