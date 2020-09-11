import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello!</h1>
        <p>Welcome to your new single-page application, built with:</p>
        <ul>
          <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
          <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
          <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
          <li><a href='https://tomchentw.github.io/react-google-maps/'>react-google-maps</a> is used for embedding google maps</li>
          <li>Axios library is used to send HTTP request to the API endpoints</li>
        </ul>
        <p>Please click  <em>Trips</em> tab to see taxi trip data for the month of January 2015</p>              
      </div>
    );
  }
}
