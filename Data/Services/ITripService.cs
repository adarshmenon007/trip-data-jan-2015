using System;
using System.Collections.Generic;

namespace TripsDataJan2015.Data{

    public interface ITripService
    {
        List<Trip> GetAllTrips();
        List<Trip> GetTripsByVendorId(int vendorId);
        List<Trip> GetTripsByDateTime(DateTime fromDateTime, DateTime toDateTime);
    }
}