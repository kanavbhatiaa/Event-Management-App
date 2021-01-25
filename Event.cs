using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Event
    {
        private int eventId;
        private string eventName;
        private string venue;
        private Date eventDate;
        private int maxAttendees;
        private int numAttendees;
        private string dateCreated;
        public Customer[] AttendeeList { get; set; }
		public string EventName
		{
			get { return eventName; }
			set { eventName = value; }
		}

		public string EventVenue
		{
			get { return venue; }
			set { venue = value; }
		}

		public string EventDate
		{
			get { return eventDate.ToString(); }
		}

		public string NumberOfAttendies
		{
			get { return maxAttendees.ToString(); }
		}

		public string EventId
		{
			get { return eventId.ToString(); }
		}

		public Event(int eventId, string name, string venue, Date eventDate, int maxAttendees)
        {
            this.eventId = eventId;
            this.eventName = name;
            this.venue = venue;
            this.eventDate = eventDate;
            this.maxAttendees = maxAttendees;
            numAttendees = 0;
            AttendeeList = new Customer[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getEventId() { return eventId; }
        public string getEventName() { return eventName; }
        public string getVenue() { return venue; }

        public Date getEventDate() { return eventDate; }

        public int getMaxAttendees() { return maxAttendees; }
        public int getNumAttendees() { return numAttendees; }

        public bool addAttendee(Customer c)
        {
            if (numAttendees >= maxAttendees) { return false; }
            AttendeeList[numAttendees] = c;
            numAttendees++;
            c.setNumBookings(c.getNumBookings() + 1);
            return true;
        }

        private int findAttendee(int custId)
        {
            for (int x = 0; x < maxAttendees; x++)
            {
                if (AttendeeList[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removeAttendee(int custId)
        {
            int loc = findAttendee(custId);
            if (loc == -1) return false;
            AttendeeList[loc] = AttendeeList[numAttendees - 1];
            numAttendees--;
            return true;
        }

        public bool attendeeExist(int custId)
        {
            for (int i = 0; i < numAttendees; i++)
            {
                if (AttendeeList[i].getId() == custId)
                {
                    return true;
                }
            }

            return false;
        }

        public string getAttendees()
        {
            string s = "\nCustomers registered :";
            for (int x = 0; x < numAttendees; x++)
            {
                s = s + "\n" + AttendeeList[x].FirstName + " " + AttendeeList[x].LastName;
                s += "\nCustomer ID: " + AttendeeList[x].getId();
            }
            return s;
        }

        public override string ToString()
        {
            string s = "Event: " + eventId + "\nName: " + eventName;
            s = s + "\nVenue: " + venue;
            s = s + "\nDate:" + eventDate;
            s = s + "\nRegistered Attendees:" + numAttendees;
            s = s + "\nAvailable spaces:" + (maxAttendees - numAttendees);
            s = s + getAttendees();
            return s;
        }
    }
}
