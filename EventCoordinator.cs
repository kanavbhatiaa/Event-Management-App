using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVP[] regs;
        private static int ticketID;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            regs = new RSVP[maxCust * maxEvents];
            ticketID = 1;
        }



        public bool register(int cid, int eid)  //consider it add RSVP
        {

            regs[ticketID] = new RSVP(eventMan, custMan, ticketID);
            regs[ticketID].setRegID(ticketID);      //use the unique generated ID and assign it to RSVP


            if (regs[ticketID].registerID(cid, eid))
            {
                ticketID++;
                return true;
            }

            return false;
        }


        public string viewRegs()
        {
            string s = "";

            for (int i = 1; i < ticketID; i++)
            {
                s += regs[i].viewRSVP();
                s += "\n-----------------\n";
            }

            return s;
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public Customer[] getCustomerList()
        {
            return custMan.getCustomers();
        }

        public Customer findCustomer(int id)
        {
            return custMan.getCustomer(id);
        }

        public int getNumCustomers()
        {
            return custMan.getNumCustomers();
        }

        public Event GetEvent(int id)
        {
            return eventMan.getEvent(id);
        }

        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public Event[] GetEvents()
        {
            return eventMan.GetEvents();
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }
    }
}
