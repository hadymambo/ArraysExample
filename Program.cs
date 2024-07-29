/*
//Declaring a new array
string [] fraudulentOrderIDs = new string [3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";


string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//Retrieving values from an array 
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//To determine the lenght of an array, we use the lenght property. The lenght of an array is not zero-based

//to report the number of fraudulent orders
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

/*
//Learning about foreach
string[] names = { "Rowena", "Robin", "Bao" };

foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

//Use the foreach statement to create a sum of all the items on hand in each bin of your warehouse.
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum +=items;
    //bin = bin + 1 is equivalent to bin++;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");


//Create a variable to hold the current bin number and display the running total
