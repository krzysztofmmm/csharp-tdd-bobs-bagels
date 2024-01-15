
namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public Dictionary<Guid , string> Bagels { get; private set; }
        public int Capacity { get; private set; }

        public Basket(int capacity)
        {
            if(capacity < 0)
                throw new ArgumentException("Capacity cannot be less than 0");
            Bagels = new Dictionary<Guid , string>();
            Capacity = capacity;
        }

        public bool AddBagel(string type)
        {
            if(string.IsNullOrEmpty(type) || Bagels.Count >= Capacity)
                return false;
            Bagels.Add(Guid.NewGuid() , type);
            return true;
        }

        public string GetBagelById(Guid id)
        {
            if(!Bagels.ContainsKey(id))
                return null;
            return Bagels[id];
        }

        public bool RemoveBagel(Guid id)
        {
            if(!Bagels.ContainsKey(id))
                return false;
            Bagels.Remove(id);
            return true;
        }

        public bool ChangeCapacity(int newCapacity)
        {
            if(newCapacity < 0)
                return false;
            Capacity = newCapacity;
            return true;
        }
    }
}


