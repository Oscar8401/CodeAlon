using System;

class Program
{
   public static void Main()
    {
        //double d = 4.55;
        //Console.WriteLine(d);
        //Console.WriteLine("Min: {0}\nMax: {1}", int.MinValue, int.MaxValue);
        //Console.WriteLine("\"hello christmas\"");
        //Console.Write("What is your name?");
        //string Fname = Console.ReadLine();
        //Console.Write("What is your sure name?");
        //string Lname = Console.ReadLine();
        //Console.WriteLine("Hello {0} {1}", Fname, Lname);
        //Console.WriteLine("Welcome to the numbers game\n Please guss a number:");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("you insert: {0}", num);
        //Console.WriteLine("How many tickets you want to buy");
        //int? TicketsOnSale = int.Parse(Console.ReadLine());
        //int Availabletickets = TicketsOnSale ?? 0;
        //Console.WriteLine("AvaialableTickets = {0}", Availabletickets);

        //Console.ReadLine();
        //float f = 123.234F;
        //we should convert here because float is larger then int
        //using type cast (int)
        //int i = (int)f;
        //or using the convert class
        //int i = Convert.ToInt32(f);
        //Console.WriteLine(f);
        //
        //string strNumber = "100F";
        //int result = 0;
        //int num = int.Parse(strNumber);
        //if you don't use the first then the tryparse need 
        //int result to stor the value
        //int.TryParse(strNumber,out result );
        //Console.WriteLine(strNumber);


        ////
        //int[] EvenNumbers = new int[3];
        //EvenNumbers[0] = 0;
        //EvenNumbers[1] = 1;
        //EvenNumbers[2] = 2;
        //Console.WriteLine(EvenNumbers[2]);
        ////
        //string[] names = new string[3];
        //names[0] = "Taleb";
        //names[1] = "Abdelhadi";
        //names[2] = "Kwsatas";
        //Console.WriteLine(names[0]);

        //
        //Console.WriteLine("Please enter a number");
        //int UserNumber = int.Parse( Console.ReadLine());
        //if (UserNumber == 1)
        //{
        //    Console.WriteLine("Yur number is one");
        //}
        //else if (UserNumber == 2)
        //{
        //    Console.WriteLine("your number is two");
        //}
        //else if (UserNumber == 3)
        //{
        //    Console.WriteLine("Your number is three");
        //}
        //else 
        //{
        //    Console.WriteLine("Your number is not between one to three");
        //}

        //if (UserNumber == 10 || UserNumber == 20)
        //{
        //    Console.WriteLine("user number is 10 or 20");
        //}
        //else
        //{
        //    Console.WriteLine("yur number in not 10 or 20");
        //}

        //Console.WriteLine("Please enter a number");
        //int UserNumber = int.Parse(Console.ReadLine());



        //if (UserNumber == 10)
        //{
        //    Console.WriteLine("your number is 10");
        //}
        //else if (UserNumber == 20)
        //{
        //    Console.WriteLine("your number is 20");
        //}
        //else if (UserNumber == 30)
        //{
        //    Console.WriteLine("your number is 30");
        //}
        //else
        //{
        //    Console.WriteLine("yur number is not 10, 20 and 30");
        //}

        //switch (UserNumber)
        //{
        //    case 10:
        //        //Console.WriteLine("your number is 10");
        //        //break;
        //    case 20:
        //        //Console.WriteLine("your number is 20");
        //        //break;
        //    case 30:
        //        Console.WriteLine("your numbe is {0}", UserNumber);
        //        break;
        //    default:
        //        Console.WriteLine("your number is not 10, 20 nd 20");
        //        break;
        //}
        //Console.ReadLine();

        //
        //here you are creating a lable.
        //lable is is a kind of mark in the program which tell the goto where to go


        //Start:
        //    int TotalCoffeecost = 0;
        //    Console.WriteLine("1. small, 2. midium, 3.large");
        //    int UserChoice = int.Parse(Console.ReadLine());

        //    switch (UserChoice)
        //    {
        //        case 1:
        //            TotalCoffeecost += 1;
        //            break;
        //        case 2:
        //            TotalCoffeecost += 2;
        //            break;
        //        case 3:
        //            TotalCoffeecost += 3;
        //            break;

        //        default:
        //            Console.WriteLine("Your choice is invalid", UserChoice);
        //            goto Start;
        //    }
        //    Decide:
        //    Console.WriteLine("Do you want a buy anothe coffee? -Yes or No");
        //    string UserDecision = Console.ReadLine();

        //    switch (UserDecision.ToUpper())
        //    {
        //        case "YES":
        //            goto Start;
        //        case "NO":
        //            break;
        //        default:
        //            Console.WriteLine("Your choice in not valid");
        //            goto Decide;
        //    }

        //    Console.WriteLine("thank you for shopping from us");
        //    Console.WriteLine("Bill Amount = {0}", TotalCoffeecost);
        //    Console.ReadLine();

        //Console.WriteLine("please enter your target?");
        //int UserTarget = int.Parse(Console.ReadLine());
        //int Start = 0;
        //while (Start <= UserTarget)
        //{
        //    Console.WriteLine(Start);
        //    Start = Start + 2;
        //}
        //Console.ReadLine();


        //string UserChoice = string.Empty;

        //do
        //{


        //Console.WriteLine("Please enter your target?");
        //int UserTarget = int.Parse(Console.ReadLine());
        //int Start = 0;
        //while (Start <= UserTarget)
        //{
        //    Console.Write(Start + " ");
        //    Start = Start + 2;
        //}
        //do
        //{
        //Console.WriteLine("Do you want to continue? - Yes or No");
        // UserChoice = Console.ReadLine().ToUpper();
        //if (UserChoice != "YES" && UserChoice != "NO")
        //{
        //    Console.WriteLine("your choice is invalid, please say Yes or No");
        //}
        //} while (UserChoice != "YES" && UserChoice != "NO");
        //} while (UserChoice == "YES");
        //Console.ReadLine();

        //int[] Numbers = new int[3];
        //Numbers[0] = 101;
        //Numbers[1] = 102;
        //Numbers[2] = 103;

        ////forech used to iterate throw a collection
        //foreach (var item in Numbers)
        //{
        //    Console.WriteLine(item);
        //}


        //for (int j = 0; j < Numbers.Length; j++)
        //{
        //    Console.WriteLine(Numbers[j]);
        //}


        //int k = 0;
        //while (k < Numbers.Length)
        //{
        //    Console.WriteLine(Numbers[k]);
        //    k++;
        //}
        //Console.ReadLine();

        //for (int i= 0 ; i <= 20; i++)
        //{
        //    //type just the even numbers
        //    if (i % 2 == 1)
        //    {
        //        continue;
        //    }
        //        Console.WriteLine(i);

        //    //if (i == 10)
        //    //{
        //    //    break;
        //    //}
        //}
        //Console.ReadLine();


        //    Program p = new Program();
        //    p.EvenNumber();
        //    //invoke the third method
        //    int Sum = p.Add(10, 20);
        //    Console.WriteLine("Sum = {0}", Sum);

        //    //invoke the second method
        //    Program.EvenNumbers(30);


        //    Console.ReadLine();


        //}
        //public void EvenNumber()
        //{
        //    int Start = 0;
        //    while (Start <= 20)
        //    {
        //        Console.WriteLine(Start);
        //        Start = Start + 2;
        //    }
        //}
        ////another method
        //public static void EvenNumbers(int Target)
        //{
        //    int Start = 0;
        //    while (Start <= Target)
        //    {
        //        Console.WriteLine(Start);
        //        Start = Start + 2;
        //    }
        //}

        //public int Add (int FN, int SN)
        //{
        //    return FN + SN;

        //int i = 0;
        //Program.SimpleMethod(ref i);
        //Console.WriteLine(i);
        //Console.ReadLine();

        //int Total = 0;
        //int Product = 0;
        //Calculate(10, 20, out Total, out Product);
        //Console.WriteLine("Sum = {0} && Prduct = {1}", Total, Product);
        //Console.ReadLine();
        //int[] numbers = new int[3];
        //numbers[0] = 101;
        //numbers[1] = 102;
        //numbers[2] = 103;
        //ParamsMethod(numbers);
        //Console.ReadLine();
    }
    //public  static void SimpleMethod (ref int j)
    //{
    //    j = 101;
    //}
    //public static void Calculate (int FN, int SN, out int Sum, out int Product)
    //{
    //    Sum =  FN + SN;
    //    Product = FN * SN;
    //}

    //public static void ParamsMethod (params int[] numbers)
    //{

    //    Console.WriteLine("There are {0} elements",numbers.Length);
    //    foreach (var item in numbers)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}


}