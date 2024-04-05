using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_N2_OOP
{
    public abstract class DateTimeDecorator(IMyDateTime myDateTime) : IMyDateTime
    {
        protected IMyDateTime myDateTime = myDateTime;

        abstract public StringBuilder GetDate();

        abstract public StringBuilder GetTime();

        abstract public StringBuilder GetDateTime();
    }
}
