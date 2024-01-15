﻿
/*
class : Basket

Properties:
Dictionary<Guid, string> Bagels: A dictionary where the key is a unique identifier (Guid) and the value is the type of the bagel (string). This represents the amoutn of bagels in the basket.
int Capacity : The maximum number of bagels the basket can hold.
Methods:
Basket(int capacity): A constructor that takes an int parameter representing the capacity of the basket and initializes the Bagels dictionary and Capacity property.
AddBagel(string type): A method that takes a string parameter representing the type of the bagel to add to the basket. This method does not return a value.
GetBagelById(Guid id): A method that takes a Guid parameter representing the id of the bagel to retrieve from the basket. This method returns a string representing the type of the bagel.
RemoveBagel(Guid id): A method that takes a Guid parameter representing the id of the bagel to remove from the basket. 
ChangeCapacity(int newCapacity): A method that takes an int parameter representing the new capacity of the basket. 
*/