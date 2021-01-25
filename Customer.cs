using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
       public class Customer
    {
        private int customerId;
        public string FirstName { get; set; }
        public string LastName { get; set; }

		public string Phone { get; set; }
        private int bookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            FirstName = fname;
            LastName = lname;
            Phone = ph;
        }

        public int getId() { return customerId; }
        public int getNumBookings() { return bookings; }

        public void setNumBookings(int bookings)
        {
            this.bookings = bookings;
        }
        public override string ToString()
        {
            string s = "Customer ID: " + customerId;
            s = s + "\nName: " + FirstName + " " + LastName;
            s = s + "\nPhone: " + Phone;
            s = s + "\nBookings: " + bookings;

            return s;
        }
    }
}
