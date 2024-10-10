using Prototype.Abstraction;

namespace Prototype
{
    public class Truck : Vehicle, IMyCloneable<Truck>, ICloneable
    {
        private bool _tractionUnit;
        public int Capacity { get; set; }

        public bool TractionUnit => _tractionUnit;

        /// <summary>
        /// Установить тип тягача
        /// </summary>
        public Truck SetTractionUnit(bool tractionUnit)
        {
            _tractionUnit = tractionUnit;
            return this;
        }

        public Truck(string brand, string model, int capacity) : base(brand, model)
        {
            Capacity = capacity;
        }

        public Truck(Truck other) : base(other)
        {
            Capacity = other.Capacity;
        }

        public override Truck CustomeClone()
        {
            return new Truck(this);
        }
    }
}
