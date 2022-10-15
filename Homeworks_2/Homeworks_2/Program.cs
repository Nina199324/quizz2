//


using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



//console.writeline("a=");
//int x = int.parse(console.readline());
//console.writeline("b=");
//int y = int.parse(console.readline());
//int number = x + y;
//console.write($"return number is: {number}");
//return number;


//int[] numbers = new int[10];
//Console.WriteLine(new int());


//Console.Write("n = ");
//int n = int.Parse(Console.ReadLine());
//int num = 2;
//int sum = 5;
//Console.Write("The sum 1:");
//while (num < n)
//{
//    num++;
//    sum += num;
//    Console.Write(" + " + num);
//}
//Console.WriteLine(" = " + sum);



//Console.Write("Enter a positive number: ");
//int num = int.Parse(Console.ReadLine());
//int divider = 2;
//int maxDivider = (int)Math.Sqrt(num);
//bool prime = true;
//while (prime && (divider <= maxDivider))
//{
//  if (num % divider == 0)
//    {
//       prime = false;
//    }
//    divider++;
//}
//Console.WriteLine("Prime? " + prime);




//Console.WriteLine("Enter a value for Array:");
//int nini=int.Parse(Console.ReadLine());
//int[]array=new int[nini];
//int[] n;
//n = new int[nini];
//Console.WriteLine("Input Elements for aray:");
//for (int i = 0; i < nini; i++) ;
//n[i] = int.Parse(Console.WriteLine);

//Console.WriteLine($"Array length is {nini}:");


//Console.WriteLine("Enter a value for Array:");
//int size;
//size = int.Parse(Console.ReadLine());
//int[] x;
//x = new int[size];
//Console.WriteLine("input elements for x:");
//for (int i = 0; i < size; i++)
//x[i] = int.Parse(Console.ReadLine());


//int size;
//Console.WriteLine("Input size:");
//size = int.Parse(Console.ReadLine());
//int[] x;
//x = new int[size];
//int[] z;
//z=new int[size];
//int[] a;
//a = new int[size];
//Console.WriteLine("Input Elements for x:");
//for (int i = 0; i < sizeof(int); i++)
//x[i] = int.Parse(Console.ReadLine());   



//int n = 10;
//int j = 1;
//int row = 2;
//while (j < n)
//{
//    for (int i = 1; i < row; i++)
//    {
//        Console.Write($"{j++} ");
//    }
//    {
//    else if (j < n) ;
//        Console.WriteLine();
//        row++;
//    }
//}   









//Homework2_1

//Console.WriteLine("Input 10 numbers for 1st array:");
//int[] array1 = new int[10];
//for (int i = 0; i < array1.Length; i++)
//{
//    array1[i] = i;
//}

//Console.WriteLine("Input 10 numbers for 2nd array:");
//string[] array2 = new string[10];
//for (int i = 0; i < array2.Length; i++)
//{
//    array2[i] = Console.ReadLine();
//}


//Homework2_2

//int n = 10;
//int x = 1;
//int row = 1;

//while (x <= n)
//{
//    for (int i = 1; i <= row; i++)
//    {
//        Console.Write($" {x++}");
//    }
//        Console.WriteLine();
//        row++;
//    }


//Homework2_3

//Console.WriteLine("Enter the values:");
//string val = Console.ReadLine();
//bool check = int.TryParse(val, out int n);
//if (check)
//{
//    int sum = 0;
//    int nam = 1;
//    for (int i = 1; i <=n; i++)
//    {
//        if (i % 2 ==1)
//        {
//            sum += i;
//            nam *= i;
//        }
//    }
//    Console.WriteLine("sum: " + (sum) +"\nnam: " +nam);
//}


//Homework2_4

//Console.WriteLine("Enter the values:");
//String val = Console.ReadLine();
//bool check = int.TryParse(val, out int n);
//if (check)
//{
//    int b = 1;
//    int sum = 0;
//    int result = 0;
//    while (b <= n)
//    {
//        result += (b * b);
//        b++;
//    }
//    Console.WriteLine($"result is: {result}");
//}

//Homework2_5


//Homework2_8  - mediana

//int[] myArray = new int[] { 1, 2, 16, 4, 18 };
//int i = 0;
//int sum = 0;
//float average = 0.0F;
//int maxValue = myArray.Max();
//int maxIndex = myArray.ToList().IndexOf(maxValue);
//int minValue = myArray.Min();
//int minIndex = myArray.ToList().IndexOf(minValue);
//int size = myArray.Length;
//for (i = 0; i < myArray.Length; i++)
//{
//    sum += myArray[i];
//}

//average = (float)sum / myArray.Length;

//Console.WriteLine($"Array length is: {size}");
//Console.WriteLine("Average value for Array: " + average);
//Console.WriteLine("Max Value in the array is:" + maxValue);
//Console.WriteLine("Min Value in the array is:" + minValue);


//Homework2_9

//{
//    int[] array = { 1, 2, 3, 4 };
//    int length = array.Length;
//    int[] reversed = new int[length];
//    for (int index = 0; index < length; index++)
//    {
//        reversed[length - index - 1] = array[index];
//    }
//    for (int index = 0; index < length; index++)
//    {
//        Console.Write(reversed[index] + " ");
//    }
//}

//Homework2_10 //from the console
//int i = 0;
//int[] arr = new int [10];

//Console.WriteLine("Enter array elements : ");
//for (i = 0; i < arr.Length; i++)
//{
//    Console.Write("Element[" + (i + 1) + "]: ");
//    arr[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("List of negative numbers : ");
//for (i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < 0)
//        Console.Write(arr[i] + " ");
//}
//Console.WriteLine();

//int i = 0;
//int[] array = { -5, -7, 0, -3, 4, 5, 9 };
//int length = array.Length;
//for (int index = 0; index > array.Length; i++)
//{
//    if (array[0] < 0) ;
//    index(i);
//}
//Console.WriteLine(index.array) + " ");


//string sometext = "Home work is done";
//Console.WriteLine(sometext.ToUpper());
//Console.WriteLine(sometext.ToLower());
////Console.WriteLine(sometext.Trim());
//Console.WriteLine(sometext.IndexOf("done")); //space itvlis
//Console.WriteLine(sometext.LastIndexOf("e")); //space_itvlis
//Console.WriteLine(sometext.Substring(3, 8));
//Console.WriteLine(sometext.Replace("is", "isnt"));
//Console.WriteLine(sometext.Insert(2, "p")); //hopme
//Console.WriteLine(String.IsNullOrEmpty(sometext)); // amotsmebs string tu aris carieli
//Console.WriteLine(string.IsNullOrWhiteSpace);

//string stringnumber = "1993";
//int intnumber = int.Parse(stringnumber);

//Console.WriteLine("how old are you?");
//string age = Console.ReadLine();
//int num2 = Int32.Parse(age);
//int newAge = num2 + 5;

//Console.WriteLine("your age is going to be after 5 years" + ":" + newAge);
////Console.WriteLine(num2);
///////////////////////////////////////////////


//int[] arr = new int[10];
//int i;
//Console.Write("\n\nRead and Print elements of an array:\n");
//Console.Write("-----------------------------------------\n");

//Console.Write("Input 10 elements in the array :\n");
//for (i = 0; i < 10; i++)
//{
//    Console.Write("element - {0} : ", i);
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.Write("\nElements in array are: ");
//for (i = 0; i < 10; i++)
//{
//    Console.Write("{0}  ", arr[i]);
//}
//Console.Write("\n");


//string message = "the value is:";
//Int32 num = 2;
//Console.Write(message + num);
//Console.ReadKey();

//double number;
//Console.Write("Enter a number:");
//number = double.Parse(Console.ReadLine());
//Console.Write(number * number);

//int i;
//for (i = 0; i < 10; ++i)
//{
//    Console.WriteLine("{0}", i);
//    //Console.WriteLine("{0}" + "{0}", i);

//}

int[] arr = { -5, -2, 12, 83, 75, 40, 95 };

Console.WriteLine("Array:");
foreach (int n in arr)
{
    Console.WriteLine(n);
}
// getting elements under zero
IEnumerable<int> myArray = arr.AsQueryable().Where((a, index) => a <= 0);
Console.WriteLine("Elements above 0...:");
foreach (int res in myArray)
{
    Console.WriteLine(res);
}