﻿using Happyhour.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Happyhour
{
    class XMLFileHandler
    {

        public void writePubXMLFile(List<LocationData> locations)
        {

            XDocument doc = new XDocument();
            doc.Add(new XElement("pubs"));

            foreach (LocationData l in locations)
            {
                XElement pub = new XElement("pub");
                XElement id = new XElement("id", l.id);
                XElement name = new XElement("name", l.name);
                XElement street = new XElement("street", l.street);
                XElement streetNumber = new XElement("streetNumber", l.streetNumber);
                XElement zipcode = new XElement("zipcode", l.zipcode);
                XElement city = new XElement("city", l.city);
                XElement country = new XElement("country", l.country);
                XElement rating = new XElement("rating", l.rating);
  
                
                XElement opentimes = new XElement("opentimes");
                if (l.pubdays.Count > 0)
                {
                    string time = "";
                    if (l.pubdays[0].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[0].open.getTimeForSaving();
                    XElement opentimesMonday = new XElement("Monday", time);

                    if (l.pubdays[1].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[1].open.getTimeForSaving();
                    XElement opentimesTuesday = new XElement("Tuesday", time);

                    if (l.pubdays[2].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[2].open.getTimeForSaving();
                    XElement opentimesWednesday = new XElement("Wednesday", time);

                    if (l.pubdays[3].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[3].open.getTimeForSaving();
                    XElement opentimesThursday = new XElement("Thursday", time);

                    if (l.pubdays[4].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[4].open.getTimeForSaving();
                    XElement opentimesFriday = new XElement("Friday", time);

                    if (l.pubdays[5].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[5].open.getTimeForSaving();
                    XElement opentimesSaterday = new XElement("Saterday", time);

                    if (l.pubdays[6].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[6].open.getTimeForSaving();
                    XElement opentimesSunday = new XElement("Sunday", time);

                    opentimes.Add(opentimesMonday);
                    opentimes.Add(opentimesTuesday);
                    opentimes.Add(opentimesWednesday);
                    opentimes.Add(opentimesThursday);
                    opentimes.Add(opentimesFriday);
                    opentimes.Add(opentimesSaterday);
                    opentimes.Add(opentimesSunday);
                }

                XElement closetimes = new XElement("closetimes");
                if (l.pubdays.Count > 0)
                {
                    string time = "";
                    if (l.pubdays[0].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[0].close.getTimeForSaving();
                    XElement closetimesMonday = new XElement("Monday", time);

                    if (l.pubdays[1].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[1].close.getTimeForSaving();
                    XElement closetimesTuesday = new XElement("Tuesday", time);

                    if (l.pubdays[2].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[2].close.getTimeForSaving();
                    XElement closetimesWednesday = new XElement("Wednesday", time);

                    if (l.pubdays[3].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[3].close.getTimeForSaving();
                    XElement closetimesThursday = new XElement("Thursday", time);

                    if (l.pubdays[4].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[4].close.getTimeForSaving();
                    XElement closetimesFriday = new XElement("Friday", time);

                    if (l.pubdays[5].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[5].close.getTimeForSaving();
                    XElement closetimesSaterday = new XElement("Saterday", time);

                    if (l.pubdays[6].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[6].close.getTimeForSaving();
                    XElement closetimesSunday = new XElement("Sunday", time);

                    closetimes.Add(closetimesMonday);
                    closetimes.Add(closetimesTuesday);
                    closetimes.Add(closetimesWednesday);
                    closetimes.Add(closetimesThursday);
                    closetimes.Add(closetimesFriday);
                    closetimes.Add(closetimesSaterday);
                    closetimes.Add(closetimesSunday);
                }
                
                XElement position = new XElement("position");
                XElement longitude = new XElement("longitude", l.longitude);
                XElement latitude = new XElement("latitude", l.latitude);

                XElement happyFrom = new XElement("happyhourfrom");
                if (l.pubdays.Count > 0)
                {
                    string time = "";
                    if (l.pubdays[0].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[0].happyhourFrom.getTimeForSaving();
                    XElement opentimesMonday = new XElement("Monday", time);

                    if (l.pubdays[1].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[1].happyhourFrom.getTimeForSaving();
                    XElement opentimesTuesday = new XElement("Tuesday", time);

                    if (l.pubdays[2].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[2].happyhourFrom.getTimeForSaving();
                    XElement opentimesWednesday = new XElement("Wednesday", time);

                    if (l.pubdays[3].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[3].happyhourFrom.getTimeForSaving();
                    XElement opentimesThursday = new XElement("Thursday", time);

                    if (l.pubdays[4].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[4].happyhourFrom.getTimeForSaving();
                    XElement opentimesFriday = new XElement("Friday", time);

                    if (l.pubdays[5].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[5].happyhourFrom.getTimeForSaving();
                    XElement opentimesSaterday = new XElement("Saterday", time);

                    if (l.pubdays[6].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[6].happyhourFrom.getTimeForSaving();
                    XElement opentimesSunday = new XElement("Sunday", time);

                    happyFrom.Add(opentimesMonday);
                    happyFrom.Add(opentimesTuesday);
                    happyFrom.Add(opentimesWednesday);
                    happyFrom.Add(opentimesThursday);
                    happyFrom.Add(opentimesFriday);
                    happyFrom.Add(opentimesSaterday);
                    happyFrom.Add(opentimesSunday);
                }

                XElement happyTo = new XElement("happyhourto");
                if (l.pubdays.Count > 0)
                {
                    string time = "";
                    if (l.pubdays[0].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[0].happyhourTo.getTimeForSaving();
                    XElement closetimesMonday = new XElement("Monday", time);

                    if (l.pubdays[1].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[1].happyhourTo.getTimeForSaving();
                    XElement closetimesTuesday = new XElement("Tuesday", time);

                    if (l.pubdays[2].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[2].happyhourTo.getTimeForSaving();
                    XElement closetimesWednesday = new XElement("Wednesday", time);

                    if (l.pubdays[3].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[3].happyhourTo.getTimeForSaving();
                    XElement closetimesThursday = new XElement("Thursday", time);

                    if (l.pubdays[4].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[4].happyhourTo.getTimeForSaving();
                    XElement closetimesFriday = new XElement("Friday", time);

                    if (l.pubdays[5].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[5].happyhourTo.getTimeForSaving();
                    XElement closetimesSaterday = new XElement("Saterday", time);

                    if (l.pubdays[6].isClosed)
                        time = "closed";
                    else
                        time = l.pubdays[6].happyhourTo.getTimeForSaving();
                    XElement closetimesSunday = new XElement("Sunday", time);

                    happyTo.Add(closetimesMonday);
                    happyTo.Add(closetimesTuesday);
                    happyTo.Add(closetimesWednesday);
                    happyTo.Add(closetimesThursday);
                    happyTo.Add(closetimesFriday);
                    happyTo.Add(closetimesSaterday);
                    happyTo.Add(closetimesSunday);
                }

                pub.Add(id);
                pub.Add(name);
                pub.Add(street);
                pub.Add(streetNumber);
                pub.Add(zipcode);
                pub.Add(city);
                pub.Add(country);
                pub.Add(rating);
                pub.Add(opentimes);

                pub.Add(closetimes);
                pub.Add(happyFrom);
                pub.Add(happyTo);
                

                position.Add(longitude);
                position.Add(latitude);
                pub.Add(position);

                doc.Root.Add(pub);
            }

            File.WriteAllText("Assets/XML/PubsInformation.xml", doc.ToString());

            Debug.WriteLine(File.ReadAllText("Assets/XML/PubsInformation.xml"));
        }

        public List<LocationData> readPubXMLFile()
        {
            XElement element;
            List<LocationData> locations = new List<LocationData>();
            LocationData location = null;

            using (XmlReader reader = XmlReader.Create("Assets/XML/PubsInformation.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString().ToUpper())
                        {
                            case "PUB":
                                location = new LocationData();
                                break;
                            case "ID":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.id = int.Parse(element.Value);
                                break;
                            case "NAME":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.name = element.Value.ToString();
                                break;
                            case "STREET":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.street = element.Value.ToString();
                                break;
                            case "STREETNUMBER":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.streetNumber = element.Value;
                                break;
                            case "ZIPCODE":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.zipcode = element.Value.ToString();
                                break;
                            case "CITY":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.city = element.Value.ToString();
                                break;
                            case "COUNTRY":
                                element = XElement.ReadFrom(reader) as XElement;
                                location.country = element.Value.ToString();
                                break;
                            case "RATING":
                                element = XElement.ReadFrom(reader) as XElement;
                                int rating;
                                int.TryParse(element.Value.ToString(), out rating);
                                location.rating = rating;
                                break;
                            case "OPENTIMES":
                                readPubTimes(reader, true, location);
                                break;
                            case "CLOSETIMES":
                                readPubTimes(reader, false, location);
                                break;
                            case "LONGITUDE":
                                element = XElement.ReadFrom(reader) as XElement;
                                Double.TryParse(element.Value.ToString(), out location.position.Longitude);
                                break;
                            case "LATITUDE":
                                element = XElement.ReadFrom(reader) as XElement;
                                Double.TryParse(element.Value.ToString(), out location.position.Latitude);
                                break;
                            case "HAPPYHOURFROM":
                                //element = XElement.ReadFrom(reader) as XElement;
                                //readHappyhours(reader, location);
                                readHappyTimes(reader, true, location);
                                break;
                            case "HAPPYHOURTO":
                                //element = XElement.ReadFrom(reader) as XElement;
                                //readHappyhours(reader, location);
                                readHappyTimes(reader, false, location);
                                break;
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name.ToString().ToUpper() == "PUB")
                        locations.Add(location);
                }
            }
            return locations;
        }

        public void writeRouteXMLFile(List<PubRoute> routes)
        {

            XDocument doc = new XDocument();
            doc.Add(new XElement("routes"));

            foreach (PubRoute p in routes)
            {
                XElement route = new XElement("route");
                XElement name = new XElement("name", p.name);
                route.Add(name);

                foreach (LocationData data in p.pubs)
                {
                    XElement pub = new XElement("pub");
                    XElement id = new XElement("id", data.id);

                    pub.Add(id);
                    route.Add(pub);
                }

                doc.Root.Add(route);
            }

            File.WriteAllText("Assets/XML/PubRoutes.xml", doc.ToString());

            Debug.WriteLine(File.ReadAllText("Assets/XML/PubRoutes.xml"));
        }

        public List<PubRoute> readRouteXMLFile(List<LocationData> pubList)
        {
            if (pubList.Count != 0)
            {
                XElement element;
                List<PubRoute> routes = new List<PubRoute>();
                PubRoute route = null;
                LocationData pubdata = new LocationData();

                using (XmlReader reader = XmlReader.Create("Assets/XML/PubRoutes.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name.ToString().ToUpper())
                            {
                                case "ROUTE":
                                    route = new PubRoute();
                                    break;
                                case "NAME":
                                    element = XElement.ReadFrom(reader) as XElement;
                                    route.name = element.Value.ToString();
                                    break;
                                case "PUB":
                                    pubdata = new LocationData();
                                    break;
                                case "ID":
                                    element = XElement.ReadFrom(reader) as XElement;
                                    int id = -1;
                                    int.TryParse(element.Value.ToString(), out id);
                                    foreach (LocationData data in pubList)
                                    {
                                        if (data.id == id)
                                        {
                                            pubdata = data;
                                            break;
                                        }
                                    }
                                    route.addPubToList(pubdata);
                                    break;
                            }
                        }
                        else if (reader.NodeType == XmlNodeType.EndElement && reader.Name.ToString().ToUpper() == "ROUTE")
                            routes.Add(route);
                    }
                }
                return routes;
            }
            else
                return null;
        }

        private void readHappyTimes(XmlReader reader, Boolean isfrom, LocationData location)
        {
            ClockTime time = new ClockTime();
            XElement element;
            string typeTime = "HAPPYHOURTO";
            int day;

            if (isfrom)
                typeTime = "HAPPYHOURFROM";

            while (reader.Read() && reader.NodeType != XmlNodeType.EndElement && reader.Name.ToString().ToUpper() != typeTime)
            {
                if (reader.IsStartElement())
                {
                    time = new ClockTime();
                    switch (reader.Name.ToString().ToUpper())
                    {
                        case "MONDAY":
                            day = 0;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            //location.addOpenTime(time);
                            else
                                //location.addCloseTime(time);
                                location.pubdays[day].happyhourTo = time;
                            break;
                        case "TUESDAY":
                            day = 1;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            else
                                location.pubdays[day].happyhourTo = time;
                            break;
                        case "WEDNESDAY":
                            day = 2;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            else
                                location.pubdays[day].happyhourTo = time;
                            break;
                        case "THURSDAY":
                            day = 3;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            else
                                location.pubdays[day].happyhourTo = time;
                            break;
                        case "FRIDAY":
                            day = 4;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            else
                                location.pubdays[day].happyhourTo = time;
                            break;
                        case "SATERDAY":
                            day = 5;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            else
                                location.pubdays[day].happyhourTo = time;
                            break;
                        case "SUNDAY":
                            day = 6;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isfrom)
                                location.pubdays[day].happyhourFrom = time;
                            else
                                location.pubdays[day].happyhourTo = time;
                            break;

                    }
                }
            }
        }

        private void readPubTimes(XmlReader reader, Boolean isOpentime, LocationData location)
        {
            ClockTime time = new ClockTime();
            XElement element;
            string typeTime = "CLOSETIMES";
            int day;

            if (isOpentime)
                typeTime = "OPENTIMES";

            while (reader.Read() && reader.NodeType != XmlNodeType.EndElement && reader.Name.ToString().ToUpper() != typeTime)
            {
                if (reader.IsStartElement())
                {
                    time = new ClockTime();
                    switch (reader.Name.ToString().ToUpper())
                    {
                        case "MONDAY":
                            day = 0;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                                //location.addOpenTime(time);
                            else
                                //location.addCloseTime(time);
                                location.pubdays[day].close = time;
                            break;
                        case "TUESDAY":
                            day = 1;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                            else
                                location.pubdays[day].close = time;
                            break;
                        case "WEDNESDAY":
                            day = 2;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                            else
                                location.pubdays[day].close = time;
                            break;
                        case "THURSDAY":
                            day = 3;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                            else
                                location.pubdays[day].close = time;
                            break;
                        case "FRIDAY":
                            day = 4;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                            else
                                location.pubdays[day].close = time;
                            break;
                        case "SATERDAY":
                            day = 5;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                            else
                                location.pubdays[day].close = time;
                            break;
                        case "SUNDAY":
                            day = 6;
                            element = XElement.ReadFrom(reader) as XElement;
                            location.pubdays[day].isClosed = FillPubHoursAndMinutes(time, element);
                            if (isOpentime)
                                location.pubdays[day].open = time;
                            else
                                location.pubdays[day].close = time;
                            break;

                    }
                }
            }
        }

        private bool FillPubHoursAndMinutes(ClockTime time, XElement element)
        {
            bool closed = false;
            string hoursminutes = element.Value.ToString();
            if (hoursminutes == "closed")
            {
                closed = true;
            }
            else
            {
                Int32.TryParse((hoursminutes[0].ToString() + hoursminutes[1].ToString()), out time.hour);
                Int32.TryParse((hoursminutes[2].ToString() + hoursminutes[3].ToString()), out time.minutes);

                if (time.hour < 10)
                    time.stringhour = "0" + time.hour;
                else
                    time.stringhour = time.hour.ToString();

                if (time.minutes < 10)
                    time.stringminutes = "0" + time.minutes;
                else
                    time.stringminutes = time.minutes.ToString();
            }

            return closed;
        }
    }
}
