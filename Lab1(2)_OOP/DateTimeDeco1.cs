using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N2_OOP
{
    public class DateTimeDeco1(IMyDateTime myDateTime) : DateTimeDecorator(myDateTime)
    {
        public override StringBuilder GetDate()
        {
            return myDateTime.GetDate().Insert(0, "AAA ");
        }

        public override StringBuilder GetTime()
        {
            return myDateTime.GetTime().Insert(0, "AAA ");
        }

        public override StringBuilder GetDateTime()
        {
            return myDateTime.GetDateTime().Insert(0, "AAA ");
        }
    }
}
