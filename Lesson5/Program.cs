//exercises-----/-----/-----/
//ex211
//int[] numbers = { 6, 9, -3, 223, 71, 0 };
//Console.WriteLine(numbers.Average());
//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * 2;
//    Console.WriteLine(numbers[i]);
//}
//if (numbers)
//{

//}
//Console.WriteLine(numbers.());
//ex
//int[] numbers = {-4, -3, -2, -1, 0, 1, 2, 3, 4};
//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for(int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach(int i in numbers)
//{
//    Console.WriteLine($"{i} \t");
//}

int[,,] myArray = new int[4, 3, 5];

myArray[0, 2, 3] = 55;

Console.WriteLine(myArray[0, 2, 3]);
Console.ReadLine();
