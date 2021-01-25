using System;

namespace StarWars
{
	public class Date
    {
		public DateTime dateTime;

        public Date(DateTime date, TimeSpan time)
        {
			dateTime = date.Date.Add(time);
		}
		
        public override string ToString()
        {
            string s =dateTime.ToString("dd MMM yyyy");
            s += " at " + dateTime.ToString("hh:mm");
            return s;
        }

		public bool Equals(DateTime date)
		{
			return date.Date == dateTime.Date && date.Hour == dateTime.Hour && date.Minute == dateTime.Minute;
		}
	}
}
