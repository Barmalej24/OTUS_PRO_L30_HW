using Prototype.Abstraction;

namespace Prototype
{
    public class Car : Vehicle, IMyCloneable<Car>, ICloneable
    {
        public int Doors { get; set; }

        public Car(string brand, string model, int doors) : base(brand, model)
        {
            Doors = doors;
        }

        public Car(Car other) : base(other)
        {
            Doors = other.Doors;
        }

        public override Car CustomeClone()
        {
            return new Car(this);
        }
    }
}
