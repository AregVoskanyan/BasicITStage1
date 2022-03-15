//operations with some value types-----/-----/-----/

//operations with value type int-----/
//(value types - byte, sbyte, short, ushort, uint, long, ulong - do the same operations, they just have other ranges)
int a = 5;
int b = 32500;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(a - b);
Console.WriteLine(b / a);
Console.WriteLine(a / b);
Console.WriteLine(b * a);
Console.WriteLine(a + b);

//operations with value type float-----/
//(value types - double(d), decimal(m) - do the same operations, they just have other ranges) 
float aa = 1.555f;
float bb = 3.7f;
Console.WriteLine(aa);
Console.WriteLine(bb);
Console.WriteLine(aa + bb);
Console.WriteLine(aa - bb);
Console.WriteLine(aa * bb);
Console.WriteLine(aa / bb);

//bool can take only 2 values either "true" or "false", default value is flase-----/
bool isFemale = false;
bool isMale = true;
Console.WriteLine($"Is female: {isFemale}");
Console.WriteLine($"Is male: {isMale}");

//operations with reference type string-----/-----/-----/
string city = "Yerevan";
Console.WriteLine(city);

string str1 = "Hello";
string str2 = "Students!";
Console.WriteLine(str1 + str2);
Console.WriteLine($"{str1} \n{str2}");

Console.WriteLine("Type your name:");
string? name = Console.ReadLine();
Console.WriteLine("Type your surname:");
string? surname = (Console.ReadLine());
Console.WriteLine($"Hello {name} {surname}");

//code example with both value types and reference type(string) in use-----/
string name1 = "Areg";
int age = 18;
bool isEmployed = false;
double weight = 64.23;

Console.WriteLine($"Name: {name1}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Weight: {weight}kg");
Console.WriteLine($"Workes: {isEmployed}");
