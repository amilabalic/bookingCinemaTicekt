using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinema
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            InitializeComponent();
        }

       async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(firstName.Text != null && lastName.Text!=null && email.Text !=null && cardNumber.Text !=null && quantity!=null)
            {
                await DisplayAlert("Book Ticket", "Your ticket has been booked!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Oops", "Something went wrong", "Try again");
            }
        }
    }
}