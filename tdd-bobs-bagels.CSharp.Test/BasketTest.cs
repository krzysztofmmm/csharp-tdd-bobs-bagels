using NUnit.Framework;

[TestFixture]
public class BasketTest
{
    private Basket basket;
    private string bagelType;

    [SetUp]
    public void SetUp()
    {
        int capacity = 5;
        basket = new Basket(capacity);
        bagelType = "Plain Bagel";
    }

    [Test]
    public void TestAddBagel()
    {
        basket.AddBagel(bagelType);
        Assert.AreEqual(1 , basket.Bagels.Count);
        Assert.IsTrue(basket.Bagels.ContainsValue(bagelType));
    }

    [Test]
    public void TestRemoveBagel()
    {
        basket.AddBagel(bagelType);
        Guid id = new Guid(basket.Bagels.Keys.GetEnumerator().Current);
        basket.RemoveBagel(id);
        Assert.AreEqual(0 , basket.Bagels.Count);
    }

    [Test]
    public void TestChangeCapacity()
    {
        int newCapacity = 10;
        basket.ChangeCapacity(newCapacity);
        Assert.AreEqual(newCapacity , basket.Capacity);
    }
}





