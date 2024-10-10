using Prototype.Abstraction;

namespace Prototype
{
    public class Motorcycle : Vehicle, IMyCloneable<Motorcycle>, ICloneable
    {
        public int EngineSize { get; set; }

        public Motorcycle(string brand, string model, int engineSize) : base(brand, model)
        {
            EngineSize = engineSize;
        }

        public Motorcycle(Motorcycle other) : base(other)
        {
            EngineSize = other.EngineSize;
        }

        public override Motorcycle CustomeClone()
        {
            return new Motorcycle(this);
        }
    }
}
