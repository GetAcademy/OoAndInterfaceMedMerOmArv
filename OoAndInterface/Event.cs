using System;
using System.Collections.Generic;

namespace OoAndInterface
{
    abstract class Event
    {
        public DateTime Date { get; }

        public Event(DateTime date)
        {
            Date = date;
        }

        public abstract void Process(Inventory inventory);
    }
}
