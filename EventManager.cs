using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
		public Event[] EventList { get; set; }


        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            EventList = new Event[maxEvents];
        }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            if (numEvents >= maxEvents) { return false; }
            for (int i = 0; i < numEvents; i++)
            {
                if (EventList[i].getVenue() == venue && EventList[i].getEventDate().Equals(eventDate.dateTime))                                
                    return false;
            }

            Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees);
            EventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        private int findEvent(int eid)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (EventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }

        public int getNumEvents()
        {
            return numEvents;
        }

        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return EventList[loc];
        }

        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            EventList[loc] = EventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return EventList[loc].ToString();
        }
        public string getEventList()
        {
            string s = "Event List:";
            for (int x = 0; x < numEvents; x++)
            {
                s = s + "\n" + EventList[x].getEventId() + " \t " + EventList[x].getEventName() + " \t " + EventList[x].getVenue();
            }
            return s;
        }

		public Event[] GetEvents()
		{
			return EventList;
		}
	}
}
