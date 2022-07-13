using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinema
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
       
        public DetailPage(Ticket ticket)
        {
            InitializeComponent();
            SelectedTicket = ticket;
            this.BindingContext = this;
        }
        public Ticket SelectedTicket { get; set; }

        async public void ImgBack_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async public void ImgBookTicket_Tapped(object sender, EventArgs e)
        { 
             
           await Navigation.PushAsync(new BookPage());
            
        }

       
    }
}