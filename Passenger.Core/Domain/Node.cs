namespace Passenger.Core.Domain
{
    public class Node
    {
        public string Address{ get; protected set; }
        public double Longitude{ get; protected set; }
        public double Latitude{ get; protected set; }

        protected Node()
        {
        }

        public Node(string address, double longitute, double latitude)
        {
            Address = address;
            Longitude = longitute;
            Latitude = latitude;
        }

    }
}