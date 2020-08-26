import React, {Component} from 'react';
import { GoogleMap, withGoogleMap, withScriptjs, Marker, InfoWindow } from "react-google-maps";

function Map(){
    return(
      <GoogleMap 
        defaultZoom={10}
        defaultCenter={{lat: 40.712776, lng:-74.005974}}    
      />
    );
  }
  
const WrappedMap = withScriptjs(withGoogleMap(Map));

export class Trips extends Component
{
    constructor(props)
    {
        super(props);

        this.state = {
            trips: [],
            loading: false
        }
    }

    // To get data form the API endpoint we will be using this life-cycle method which will send the request once the UI is loaded
    componentDidMount()
    {
        this.populateTripsData();
    }

    // We will be sending the GET request to our API end points here.
    populateTripsData()
    {

    }

    // This function will return the map with all data
    renderAllTripsOnMap(trips){
        return (
            <div style={{ width: "100vw", height: "100vh" }}>
              <WrappedMap
                googleMapURL={`https://maps.googleapis.com/maps/api/js?v=3.exp&libraries=geometry,drawing,places&key=${
                  process.env.REACT_APP_GOOGLE_KEY
                }`}
                loadingElement={<div style={{ height: `100%`}} />}
                containerElement={<div style={{ height: `100%`}} />}
                mapElement={<div style={{ height: `100%`, width: `60%` }} />}
              />
            </div>       
          );
    }

    render()
    {
        let content = this.state.loading ? 
        (<p><em>Loading...</em></p>): (this.renderAllTripsOnMap(this.state.trips))

        return (           
            <div>
                <h1>All trips</h1>
                <p>Here you can see all trips</p>
                {content}  
            </div>                      
        );        
    }
}