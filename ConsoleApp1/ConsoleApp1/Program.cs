// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information



//1.დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
//კენტი რიცხვების ჯამი
//ლუწი რიცხვების ნამრავლი
//დაითვლის მასივში თითოეული ელემენტის რაოდენობას  (3)

//Console.WriteLine("Enter the Massive length: ");
//int length = int.Parse(Console.ReadLine());
//int[] arr = new int[length];
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine("enter arr elements");
//    string num = Console.ReadLine();
//    bool check = int.TryParse(num, out int a);
//    if (check)
//    {
//        arr[i] = a;
//    }

//}
//int mulnumber = 1;
//int sumnumber = 0;
//int sum = 0;

//foreach (int v in arr)
//{
//    if (arr[v - 1] % 2 == 0)
//    {
//        mulnumber = mulnumber * arr[v - 1];

//    }
//    else
//    {
//        sumnumber = sumnumber + arr[v - 1];
//    }
//    sum = sum + arr[v - 1];
//}




//2. დაწერეთ პროგრამა რომელიც სტრინგისთვის დაბეჭდავს
//არის თუ არა მოცემული სტრინგი პალინდრომი 
//(პალინდრომის მეთოდი გაიტანეთ ცალკე და გამოიძახეთ სხვადასხვა სტრინგისთვის)   (2)

//Console.WriteLine("shevamotsmot stringi, gasagrdzeleblad davachirot 1-ians");
//int check = int.Parse(Console.ReadLine());
//if (check == 1)
//{
//    //int result;

//    CheckIfStringIsRevarsable();
//}



//static void CheckIfStringIsRevarsable()
//{
//    Console.WriteLine("Enter the string: ");
//    string num = Console.ReadLine();
//    int length = num.Length;
//    int c = length / 2;
//    int b = num.Length % 2;
//    int i = 0;
//    int j = 1;
//    if (b == 0)
//    {
//        while (c != i)
//        {
//            if (num[i] != num[length - j])
//            {
//                Console.WriteLine("no reversable");
//                break;
//            }
//            j++;
//            i++;
//            if (i == c)
//            {
//                Console.WriteLine("revarsable");
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("no reversable");
//    }
//}


//3. დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად
//მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს.
//Მაგ 1 1 2 2 2 3 4 2 2  - უნდა დაბეჭდოს 3  და 2.  (3)



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






//4.(ბონუსი)დაწერეთ პროგრამა რომელიც მასივში იპოვნის
//ყველაზე ხშირად გამეორებული ელემენტის რაოენობას და დაბეჭდავს ამ ელემენტს. (2)


//int[] array = { 0, 5, 3, 2, 2, 3, 9, 5, 5, 6, 9, 8, 9, 11, 9, 12 };

//var groupped = array
//    .GroupBy(x => x)
//    .OrderByDescending(grp => grp.Count())
//    .FirstOrDefault();

//Console.WriteLine($"{groupped.Key} is repeated {groupped.Count()} time(s).");