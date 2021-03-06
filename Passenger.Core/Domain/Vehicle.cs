using System;

namespace Passenger.Core.Domain
{
    public class Vehicle
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; protected set; }

        protected Vehicle()
        {
        }

        public Vehicle(string brand, string name, int seats)
        {
            SetBrand(brand);
            SetName(name);
            SetSeats(seats);
        }

        private void SetSeats(int seats)
        {
            if (seats < 1)
            {
                throw new Exception("You cannot have 0 or less seats");
            }
            if (seats > 99)
            {
                throw new Exception("Max number of seats is 99");
            }
            Seats = seats;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Please provide valid name");
            }
            if (Name == name)
            {
                return;
            }
            Name = name;
        }

        private void SetBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new Exception("Please provide valid name");
            }
            if (Brand == brand)
            {
                return;
            }
            Brand = brand;
        }

        public static Vehicle Create(string brand, string name, int seats)
            => new Vehicle(brand, name, seats);
    }
}