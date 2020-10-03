"use strict";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 10
   Review Assignment

   Author:Hasan Mohammad 
   Date:   06-24-2019 

	
*/


/*   Date test     */
                    
 var thisDay = new Date('August 30, 2018');

var tableHTML = "<table id='eventTable'>" +
    "<caption>Upcoming Events</caption>" +
    "<tr><th>Date</th><th>Event</th><th>Price</th></tr>";

/* 14 days older than thisDay Variable */
var endDate = new Date(thisDay.getTime() + 14*24*60*60*1000);


/* For Loop  see pg 756, 761 10-8  and logical operator 10-11 */          

for (var i = 0; i < eventDates.length; i++) {
        var eventDate = new Date(eventDates[i]);
        var eventDay = eventDate.toDateString();
        var eventTime = eventDate.toLocaleTimeString();
  
  
  /* IF Statement 10-4, 10-12 see figure 9-25 */
  if (thisDay <= eventDate && eventDate <= endDate) {
        tableHTML += "<tr><td>" + eventDay + "@" + eventTime + "</td>" + "<td>" + eventDescriptions[i] + "</td>" + "<td>" + eventPrices[i] + "</td>" + "</tr>"
    
        }
        
    }
 

tableHTML +="</table>";
        
document.getElementById("eventList").innerHTML = tableHTML;




