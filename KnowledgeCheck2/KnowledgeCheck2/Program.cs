using KnowledgeCheck2;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("How many cheeseburgers do you want to add? ");
		int numberOfRecords = int.Parse(Console.ReadLine());

		var recordList = new List<Food>();
		for (int i = 0; i < numberOfRecords; i++)
		{
			Console.WriteLine("Enter a name for the cheeseburger.");
			string itemName = Console.ReadLine();

			Console.WriteLine("Enter the number of toppings for this cheeseburger: ");
			int toppings = int.Parse(Console.ReadLine());

			var cheeseburger = new Cheeseburger(itemName, toppings);

			recordList.Add(cheeseburger);
		}

		Console.WriteLine("List of cheeseburgers:");
		foreach (var food in recordList)
		{
			Console.WriteLine(food.ToString());
		}
	}
}