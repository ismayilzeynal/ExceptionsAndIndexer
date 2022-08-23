using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexer.Utilies.Exceptions
{
    class NotFoundException : Exception
    {
        public NotFoundException()
        {
            Console.WriteLine("Not found");
        }
    }
}
