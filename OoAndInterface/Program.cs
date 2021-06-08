using System;

namespace OoAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockList = new StockList();
            var transactions = new FileTransactionsCsvGetter();
            var eventsReader = new EventsReader(transactions);
            var eventList = eventsReader.Get(stockList);
        }
    }
}
