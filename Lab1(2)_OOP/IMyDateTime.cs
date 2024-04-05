using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N2_OOP
{
    public interface IMyDateTime
    {
        public StringBuilder GetDate();

        public StringBuilder GetTime();

        public StringBuilder GetDateTime();
    }
}
