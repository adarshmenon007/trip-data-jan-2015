
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TripsDataJan2015.Data{
    public class TripService : ITripService
    {
        public List<Trip> GetAllTrips()
        {
            List<Trip> allTrips = new List<Trip>(); 

            try
            {
                string fileName = "yellow_tripdata_2015-01-Edited.csv";
                string path = Path.Combine(Environment.CurrentDirectory,  @"Data\Utilities\", fileName);

                var lines = File.ReadAllLines(@path);

                for(int i = 1; i < lines.Count() ; i++)
                {
                    string[] values = lines[i].Split(',');

                    if (!string.IsNullOrWhiteSpace(values[0]))
                    {
                        Trip trip = new Trip();

                        trip.VendorId = Convert.ToInt32(values[0]);
                        trip.PickUpDateTime = Convert.ToDateTime(values[1]);
                        trip.DropOffDateTime = Convert.ToDateTime(values[2]);
                        trip.PassengerCount = Convert.ToInt32(values[3]);
                        trip.TripDistance = Convert.ToDouble(values[4]);
                        
                        trip.PickUpLongitude = Convert.ToDouble(values[5]);
                        trip.PickUpLatitude = Convert.ToDouble(values[6]);
                        trip.RateCodeID = Convert.ToInt32(values[7]);
                        trip.StoreAndFwdFlag = values[8];
                        trip.DropOffLongitude = Convert.ToDouble(values[9]);
                        trip.DropOffLatitude = Convert.ToDouble(values[10]);

                        trip.PaymentType = Convert.ToInt32(values[11]);
                        trip.FareAmount = Convert.ToDouble(values[12]);
                        trip.Extra = Convert.ToDouble(values[13]);
                        trip.MtaTax = Convert.ToDouble(values[14]);
                        trip.TipAmount = Convert.ToDouble(values[15]);
                        trip.TollsAmount = Convert.ToDouble(values[16]);
                        trip.ImprovementSurcharge = Convert.ToDouble(values[17]);
                        trip.TotalAmount = Convert.ToDouble(values[18]);

                        allTrips.Add(trip);
                    }                    
                }                 

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Exception encountered while reading csv file :", ex);

            }                                        

           return allTrips;
        }

        public List<Trip> GetTripsByDateTime(DateTime fromDateTime, DateTime toDateTime)
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetTripsByVendorId(int vendorId)
        {
            throw new NotImplementedException();
        }
    }
}