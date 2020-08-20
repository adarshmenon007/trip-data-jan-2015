using System;
using System.Globalization;

namespace TripsDataJan2015.Data{

    public class Trip
    {
        public int VendorId { get; set; }
        public DateTime PickUpDateTime { get; set; }
        public DateTime DropOffDateTime { get; set; }
        public int PassengerCount { get; set; }
        public double TripDistance { get; set; }
        public double PickUpLongitude { get; set; }
        public double PickUpLatitude { get; set; }
        public int RateCodeID { get; set; }
        public string StoreAndFwdFlag { get; set; }
        public double DropOffLongitude { get; set; }
        public double DropOffLatitude { get; set; }
        public int PaymentType { get; set; }
        public double FareAmount { get; set; }
        public double Extra { get; set; }
        public double MtaTax { get; set; }
        public double TipAmount { get; set; }
        public double TollsAmount { get; set; }
        public double ImprovementSurcharge { get; set; }
        public double TotalAmount { get; set; }
    }
}