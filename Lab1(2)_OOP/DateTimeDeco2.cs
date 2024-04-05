using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N2_OOP
{
    public class DateTimeDeco2(IMyDateTime myDateTime) : DateTimeDecorator(myDateTime)
    {
        public override StringBuilder GetDate()
        {
            return myDateTime.GetDate().Append(" BBB");
        }

        public override StringBuilder GetTime()
        {
            return myDateTime.GetTime().Append(" BBB");
        }

        public override StringBuilder GetDateTime()
        {
            return myDateTime.GetDateTime().Append(" BBB");
        }
    }
}
