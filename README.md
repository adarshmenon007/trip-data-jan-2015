# trip-data-jan-2015

New York City has publicly released Taxi trip data for every trip from every taxi from 2014 to 2018. About 131 mil trips per year. This data is available free of charge from the NYC Google BigQuery instance found here: https://console.cloud.google.com/marketplace/details/city-of-new-york/nyc-tlc-trips?pli=1.

This dataset should form the basis for your activity, and to keep it manageable, use this link to the January data (1.8GB) https://obzervropendata.blob.core.windows.net/open-access/yellow_tripdata_2015-01.csv

The Activity

Write an API to allow the map site to let the user see this data on a map:

- They should be able to zoom down to an individual point, but they only need to see the individual points once they are close enough.
- They should have a representation of all the points within a given zoom level, without downloading all the points to get this representation.
- Use either React or Angular for the frontend.

Test API using Postman
- /api/Trips/GetAllTrips