using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsIndexer.Models
{
    class Room
    {
        public Room(string Name, float Price, int PersonCapacity)
        {
            Id++;
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
        }
        public Room(string Name, float Price, int PersonCapacity, bool IsAvailable) : this(Name, Price, PersonCapacity)
        {
            this.IsAvailable = IsAvailable;
        }


        public readonly int Id;
        private string _name;
        private float _price;
        private int _personCapacity;
        private bool _isAvailable;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public float Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }

        public int PersonCapacity
        {
            get => _personCapacity;
            set
            {
                if (value > 0)
                    _personCapacity = value;
            }
        }
        

        public bool IsAvailable {
            get => _isAvailable;
            set
            {
                _isAvailable = value;
            }
        }









        public override string ToString()
        {
            return $"Name: { Name} \nPrice: { Price} \nPerson capacity: { PersonCapacity} \nAvailable: { IsAvailable} \nID: { Id}";
        }
       
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nPrice: {Price} \nPerson capacity: {PersonCapacity} \nAvailable: {IsAvailable} \nID: {Id}");
        }
    }
}
