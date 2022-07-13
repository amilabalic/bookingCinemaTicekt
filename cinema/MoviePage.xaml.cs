using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinema
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviePage : ContentPage
    {
 
        public MoviePage()
        {
            InitializeComponent();
            Tickets = GetTickets();
            this.BindingContext = this;

        }
        public ObservableCollection<Ticket> Tickets { get; set; }

        public Ticket SelectedTicket { get; set; }
        

        public ObservableCollection<Ticket> GetTickets()
        {
            return new ObservableCollection<Ticket>
            {
                new Ticket { MovieTitle = "Doctor Strange in the Multiverse of Madness", Image = "ds.jpg", ShowingDate = "05.07.2022", Description="Doctor Strange teams up with a mysterious teenage girl from his dreams who can travel across multiverses, to battle multiple threats, including other-universe versions of himself, which threaten to wipe out millions across the multiverse. They seek help from Wanda the Scarlet Witch, Wong and others.",Price=5.0,ShowingTime="17:30",Rate=7.3, Genre="Action/Adventure/Fantasy",Language="English", Duration="2h 6m"},
                new Ticket { MovieTitle = "The Lost City", Image = "lostcity.jpg", ShowingDate = "30.6.2022", Description="A reclusive romance novelist on a book tour with her cover model gets swept up in a kidnapping attempt that lands them both in a cutthroat jungle adventure.",Price=6.0,ShowingTime="20:00",Rate=6.2,Genre="Action/Adventure/Comedy",Language="English",Duration="1h 52m"},
                new Ticket { MovieTitle = "Last Seen Alive", Image = "lastseen.jpg", ShowingDate = "25.06.2022", Description="Will's soon-to-be ex-wife mysteriously vanishes at a gas station. He delves into the town's criminal underbelly while running from the authorities in a race against time to find her." ,Price=5.50,ShowingTime="22:00",Rate=5.6,Genre="Action/Mystery/Thriller",Language="English",Duration="1h 35m"},
                new Ticket { MovieTitle = "Top Gun: Maverick", Image = "topgun.jpg", ShowingDate = "20.06.2022", Description="After more than thirty years of service as one of the Navy's top aviators, Pete Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him.",Price=7.0,ShowingTime="21:00",Rate=8.6,Genre="Action/Drama",Language="English",Duration="2h 10m" }
                
            };
        }

        private void TicketSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                this.Navigation.PushAsync(new DetailPage(SelectedTicket));
            }
        }

        
    }

    public class Ticket
    {
        public string MovieTitle { get; set; }
        public string ShowingDate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ShowingTime { get; set; }
        public double Rate { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Duration { get; set; }
    }

}