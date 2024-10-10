using Xunit;

namespace Prototype.Tests
{
    public class TestCopyObject
    {
        public Truck GetTestData()
        {
            return new Truck
            (
               brand: "MAN",
               model: "TGX 18.470",
               capacity: 470
            )
            .SetTractionUnit(true);
        }

        [Fact]
        public void Test_SomePropertiesAreNotEqual()
        {
            var truck = GetTestData();
            var replica = (Truck)truck.Clone();

            Assert.Equal(truck.Brand, replica.Brand);
            Assert.Equal(truck.Model, replica.Model);
            Assert.Equal(truck.Capacity, replica.Capacity);
            Assert.NotEqual(truck.TractionUnit, replica.TractionUnit);
        }

        [Fact]
        public void Test_AllPropertiesAreEquel()
        {
            var truck = GetTestData();
            var replica = truck.CustomeClone();

            truck.SetTractionUnit(false);

            Assert.Equal(truck.Brand, replica.Brand);
            Assert.Equal(truck.Model, replica.Model);
            Assert.Equal(truck.Capacity, replica.Capacity);
            Assert.Equal(truck.TractionUnit, replica.TractionUnit);
        }
    }
}
