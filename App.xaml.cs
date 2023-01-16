using HotelReservation_MVVM.Exceptions;
using HotelReservation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelReservation_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Craig Hotel Suites");

            try 
            {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "Simba",
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 2)));

                hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "Simba",
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 4)));
            } 
            catch (ReservationConflictException ex) 
            { 

            }

            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Simba");
            base.OnStartup(e);
        }
    }
}
