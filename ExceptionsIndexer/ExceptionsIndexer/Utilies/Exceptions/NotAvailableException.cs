using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexer.Utilies.Exceptions
{
    class NotAvailableException : Exception
    {
        public NotAvailableException()
        {
            Console.WriteLine("Not available");
        }
    }
}
