string firstName = "Black";
string lastName = "Coder";
int age = 29;

// Method to get the full name and age of a person
string GetFullName(string firstName, string lastName, int age)
{
    string fullNameWithAge = $"The full name is: {firstName} {lastName} - {age}";
    return fullNameWithAge;
}

// Calling the method to get the full name and age of three students
string existingStudent = GetFullName(firstName, lastName, age);
string firstStudentFullName = GetFullName("Black", "Coder", 29);
string secondStudentFullName = GetFullName("TrickSo", "Logic", 29);

// Printing the full names and ages of the three students
Console.WriteLine("--------------------------");
Console.WriteLine(existingStudent);
Console.WriteLine(firstStudentFullName);
Console.WriteLine(secondStudentFullName);
Console.WriteLine("--------------------------");

// Creating a list of booleans and a list of student ages
List<bool> booleanList = new List<bool>() { true, false, true };
List<int> studentAges = new List<int>() { 20, 21, 20 };

// Creating an array of student ages
int[] studentAgesArray = new int[3];
