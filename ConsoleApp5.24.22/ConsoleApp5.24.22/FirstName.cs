using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5._24._22
{
    public abstract class FirstName
    {
    }

    public abstract class EmailAddress
    {
        public LastName LastName
        {
            get => default;
            set
            {
            }
        }
    }

    public abstract class LastName : ConsoleApp5_24_22.Person
    {
    }
}