using Prototype.Abstraction;

namespace Prototype
{
    public class Vehicle : IMyCloneable<Vehicle>, ICloneable
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Vehicle(Vehicle other)
        {
            Brand = other.Brand;
            Model = other.Model;
        }

        public virtual Vehicle CustomeClone()
        {
            return new Vehicle(this);
        }

        public object Clone()
        {
            return CustomeClone();
        }
    }
}
