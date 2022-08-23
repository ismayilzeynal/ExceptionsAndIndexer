using ExceptionsIndexer.Utilies.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexer.Models
{
    class Hotel
    {
        public Hotel(int length)
        {
            _rooms = new Room[length];
        }

        private Room[] _rooms;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Room this[int index]
        {
            get
            {
                if (index < _rooms.Length)
                {
                    return _rooms[index];
                }
                else
                    throw new NotFoundException();
            }
            set
            {
                if (index < _rooms.Length)
                {
                    _rooms[index] = value;
                }
                else
                    throw new NotAvailableException();
            }

        }


        public void AddRoom(Room room)
        {
            // arraya elave etmek
        }


    }
}
