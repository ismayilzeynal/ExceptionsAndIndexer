using ExceptionsIndexer.Models;
using System;

namespace ExceptionsIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Room Neptun = new Room("Neptun", 1800, 4, true);
            Room Moon = new Room("Moon", 200, 1, true);
            Room Sirius = new Room("Sirius", 5000, 2, false);
            Hotel CodeHotel = new Hotel(3);
            CodeHotel[0] = Neptun;
            CodeHotel[1] = Moon;
            CodeHotel[2] = Sirius;

            Console.WriteLine(CodeHotel[1]);

        }
    }
}
