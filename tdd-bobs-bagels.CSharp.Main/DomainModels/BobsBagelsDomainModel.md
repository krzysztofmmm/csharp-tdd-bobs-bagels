
/*
class : Basket

Properties:
Dictionary<Guid, string> Bagels: A dictionary where the key is a unique identifier (Guid) and the value is the type of the bagel (string). 
int Capacity : The maximum number of bagels the basket can hold.
Methods:
Basket(int capacity): A constructor that takes an int parameter representing the capacity of the basket and initializes the Bagels dictionary and Capacity property. 
It throws an ArgumentException if the capacity is less than 0.
bool AddBagel(string type): A method that takes a string parameter representing the type of the bagel to add to the basket. 
It returns a bool indicating whether the operation was successful. It returns false if the type is null or empty, or if the basket is full.
string GetBagelById(Guid id): A method that takes a Guid parameter representing the id of the bagel to retrieve from the basket. 
It returns a string representing the type of the bagel, or null if the bagel does not exist.
bool RemoveBagel(Guid id): A method that takes a Guid parameter representing the id of the bagel to remove from the basket. 
It returns a bool indicating whether the operation was successful. It returns false if the bagel does not exist.
bool ChangeCapacity(int newCapacity): A method that takes an int parameter representing the new capacity of the basket. 
It returns a bool indicating whether the operation was successful. It returns false if the new capacity is less than 0.
*/