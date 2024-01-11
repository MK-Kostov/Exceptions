//Console.WriteLine("Enter a number:");
//string input = Console.ReadLine();
//try
//{
//	int number = ParseStringToInt(input);
//	var result = 10 / number;
//	Console.WriteLine($"10 / {number} is " + result);

//}
//catch (FormatException ex)
//{
//	Console.WriteLine("Wrong format. Input string is not parsable to int. " + "Exception message: " + ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//	Console.WriteLine("Division by zero is an invalid operation. " + "Exception message: " + ex.Message);
//}
//catch (Exception ex)
//{
//	Console.WriteLine("Unexpected error occurred. " + "Exception message: " + ex.Message);
//}
//finally
//{
//	Console.WriteLine("Finally block is being executed.");
//}

//Console.ReadKey();

//int ParseStringToInt(string input)
//{
//	return int.Parse(input);
//}

try
{
	var result = GetFirstElement(new int[0]);
}
catch
{

}

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
	foreach (var number in numbers)
	{
		return number;
	}

	throw new Exception("The collection cannot be empty");
}

var invalidPersonObject = new Person("", -100);

Console.ReadKey();

class Person
{

	public string Name { get; }
	public int YearOfBirth { get; }

	public Person(string name, int yearOfBirth)
	{
		if (name == string.Empty)
		{
			throw new Exception("The name cannot be empty.");
		}
		if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
		{
			throw new Exception("The year of birth must be " + "between 1900 and current year.");
		}
		Name = name;
		YearOfBirth = yearOfBirth;
	}
}
