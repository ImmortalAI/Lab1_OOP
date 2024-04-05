using Lab1_N2_OOP;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N2_OOP
{
    public class EuropeDateTime : IMyDateTime
    {
        protected DateTime dateTime;

        public EuropeDateTime()
        {
            dateTime = DateTime.Now;
        }

        public StringBuilder GetDate() => new( dateTime.ToString("d", new CultureInfo("es-ES", false)));

        public StringBuilder GetTime() => new(dateTime.ToString("t", new CultureInfo("es-ES", false)));

        public StringBuilder GetDateTime() => new(dateTime.ToString("g", new CultureInfo("es-ES", false)));
    }
}
