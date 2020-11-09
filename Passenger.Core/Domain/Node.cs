using System;
using System.Text.RegularExpressions;

namespace Passenger.Core.Domain
{
    public class Node
    {
        private static readonly Regex NameRegex = new Regex("^(?![_.-])(?!.*[_.-]{2})[a-zA-Z0-9._.-]+(?<![_.-])$");
        public string Address{ get; protected set; }
        public double Longitude{ get; protected set; }
        public double Latitude{ get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        protected Node()
        {
        }

        public Node(string address, double longitute, double latitude)
        {
            SetAddress(address);
            SetLongitude(longitute);
            SetLatitude(latitude);
        }

        private void SetLatitude(double latitude)
        {
            if(!double.IsNaN(latitude))
            {
                throw new Exception("Please enter valid value.");
            }
            if (Latitude == latitude)
            {
                return;
            }
            Latitude = latitude;
            UpdatedAt = DateTime.UtcNow;
        }

        private void SetLongitude(double longitute)
        {
            if(!double.IsNaN(longitute))
            {
                throw new Exception("Please enter valid value.");
            }
            if (Longitude == longitute)
            {
                return;
            }
            Longitude = longitute;
            UpdatedAt = DateTime.UtcNow;
        }

        private void SetAddress(string address)
        {
            if (!NameRegex.IsMatch(address))
            {
                throw new Exception ("Address is invalid.");
            }
            Address = address;
            UpdatedAt = DateTime.UtcNow;
        }

        public static Node Create(string address, double longitute, double latitude)
            => new Node(address, longitute, latitude);
    }
}