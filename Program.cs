
//Task 1
Console.WriteLine("Task 1");
string name = "John Doe";
int age = 25;
bool isAdmin = true;
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(isAdmin);

//Task 2
Console.WriteLine("Task 2");
Console.Write("Write an integer: ");
string userInput = Console.ReadLine();

	if (int.TryParse(userInput, out int number))
	{
	  //Checking if number is Odd or Even
		if (number % 2 == 0)
		{
			Console.WriteLine("Even");
		}
		else
		{
			Console.WriteLine("Odd");
		}
	}
	else
	{
		Console.WriteLine("Invalid input. Please enter a valid integer.");
}
//Task 3
Console.WriteLine("Task 3");
  int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
  for(int i = 0; i < arr.Length; i++)
{
	Console.WriteLine(arr[i]);
}

//Task 4
Console.WriteLine("Task 4");
int[] arr2 = [2, 4, 6, 8, 10];
int sum = 0;
for (int i = 0; i < arr2.Length; i++)
{
	sum += arr2[i];
}
Console.WriteLine("Sum of the Array: " + sum);

for (int i = 0; i < arr2.Length; i++)
{
	Console.WriteLine(arr2[i]);
}


//Task 5
Console.WriteLine("Task 5");
void Greet(string name)
{
	Console.WriteLine("Hello," + name + "!");
}
Greet("Alice");

