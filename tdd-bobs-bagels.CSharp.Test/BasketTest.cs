using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        private Basket _basket;
        private string _bagelType;

        [SetUp]
        public void SetUp()
        {
            int capacity = 5;
            _basket = new Basket(capacity);
            _bagelType = "Plain Bagel";
        }

        [Test]
        public void TestAddBagel()
        {
            _basket.AddBagel(_bagelType);
            Assert.AreEqual(1 , _basket.Bagels.Count);
            Assert.IsTrue(_basket.Bagels.ContainsValue(_bagelType));
        }

        [Test]
        public void TestRemoveBagel()
        {
            _basket.AddBagel(_bagelType);
            var enumerator = _basket.Bagels.Keys.GetEnumerator();
            enumerator.MoveNext();
            Guid id = enumerator.Current;
            _basket.RemoveBagel(id);
            Assert.AreEqual(0 , _basket.Bagels.Count);
        }

        [Test]
        public void TestChangeCapacity()
        {
            int newCapacity = 10;
            _basket.ChangeCapacity(newCapacity);
            Assert.AreEqual(newCapacity , _basket.Capacity);
        }
    }
}


