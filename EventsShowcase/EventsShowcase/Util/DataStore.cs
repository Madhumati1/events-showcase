using EventsShowcase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EventsShowcase.Util
{
    public static class DataStore
    {
        private static List<EventModel> allEventsList = new List<EventModel>();

        private static List<EventModel> initializeEventsList()
        {

            Debug.WriteLine("################### Calling initializeEventsList");
            List<EventModel> eventsList = new List<EventModel>();

            EventModel em1 = new EventModel();
            em1.ID = 0;
            em1.Title = "Vegtoberfest";
            em1.Location = "Camden Market - Stables Market, Primrose Hill";
            em1.City = "London";
            em1.Category = "Food";
            em1.StartDate = new DateTime(2018, 10, 02);
            em1.EndDate = new DateTime(2018, 10, 05);
            em1.Description = "If you're all for beer, but not quite feeling the bratwurst, Vegtoberfest is making all your meat-free party dreams come true...";
            em1.Price = "10.00";
            em1.Organizer = "Camden Market Association";
            em1.Contact = "https://www.camdenmarket.com/";
            em1.Image = "~/images/events/1.jpg";

            EventModel em2 = new EventModel();
            em2.ID = 1;
            em2.Title = "UK Film Festival";
            em2.Location = "Cineworld Leicester Square, Bristol";
            em2.City = "Bristol";
            em2.Category = "Entertainment";
            em2.StartDate = new DateTime(2018, 10, 10);
            em2.EndDate = new DateTime(2018, 10, 21);
            em2.Description = "Screening of various films at various venues across London...";
            em2.Price = "7.00";
            em2.Organizer = "BFI UK";
            em2.Contact = "http://www.bfi.org.uk/lff";
            em2.Image = "~/images/events/2.jpg";

            EventModel em3 = new EventModel();
            em3.ID = 2;
            em3.Title = "Six Day Glasgow";
            em3.Location = "Lee Valley Velopark, Glasgow";
            em3.City = "Glasgow";
            em2.Category = "Sports";
            em3.StartDate = new DateTime(2018, 10, 23);
            em3.EndDate = new DateTime(2018, 10, 28);
            em3.Description = "Over the six days see cyclists from all over the world compete in a whole host of fast and furious races...";
            em3.Price = "15.00";
            em3.Organizer = "Six Day Association";
            em3.Contact = "https://sixday.com/";
            em3.Image = "~/images/events/3.jpg";


            eventsList.Add(em1);
            eventsList.Add(em2);
            eventsList.Add(em3);

            return eventsList;
        }

        public static List<EventModel> getEventsList()
        {
            if (allEventsList.Count == 0)
            {
                allEventsList = initializeEventsList();
            }

            return allEventsList;
        }

    }
}
