using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N2_OOP
{
    public class USDateTime : IMyDateTime
    {
        protected DateTime dateTime;

        public USDateTime()
        {
            dateTime = DateTime.Now;
        }

        public StringBuilder GetDate() => new(dateTime.ToString("d", new CultureInfo("us-US", false)));

        public StringBuilder GetTime() => new(dateTime.ToString("t", new CultureInfo("us-US", false)));

        public StringBuilder GetDateTime() => new(dateTime.ToString("g", new CultureInfo("us-US", false)));
    }
}
