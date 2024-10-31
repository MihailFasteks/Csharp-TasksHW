// See https://aka.ms/new-console-template for more information
//task1
//Console.WriteLine("Task1");
//Console.WriteLine("Input your value (min 1 max 100");
//int temp = int.Parse(Console.ReadLine());

//if (temp < 1 && temp > 100)
//{
//    Console.WriteLine("Error! Wrong value!");

//}
//else if (temp % 3 == 0 && temp % 5 != 0)
//{
//    Console.WriteLine("Fizz");
//}
//else if (temp % 5 == 0 && temp % 3 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else if (temp % 3 == 0 && temp % 5 == 0)
//{
//    Console.WriteLine("Fizz Buzz");

//}
//else if (temp % 3 != 0 && temp % 5 != 0)
//{
//    Console.WriteLine($"Value: {temp}");

//}
//task2
//Console.WriteLine("Task2");
//Console.WriteLine("Input your value");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Input your %");
//int percent= int.Parse(Console.ReadLine());

//Console.WriteLine((num1/100)*percent);


//task3
//Console.WriteLine("Task3");
//Console.WriteLine("Input your value 1");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Input your value 2");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Input your value 3");
//int num3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Input your value 4");
//int num4 = int.Parse(Console.ReadLine());
//string str = num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString();

//Console.WriteLine(str);

//task4
//Console.WriteLine("Task4");
//Console.WriteLine("Input your value of 6");
//string num=Console.ReadLine();


//if (num.Length != 6)
//{
//    Console.WriteLine("Error! Wrong lenght of value!");
//}
//else
//{
//    Console.WriteLine("Input your first index");
//    int in1= int.Parse(Console.ReadLine());
//    Console.WriteLine("Input your second index");
//    int in2 = int.Parse(Console.ReadLine());
//    if (in1<0 || in2<0 || in1>num.Length-1 || in2 > num.Length-1)
//    {
//        Console.WriteLine("Wrong index");
//    }
//    else
//    {
//        char temp1 = num[in2];
//        char temp2 = num[in1];
//        num = num.Remove(in1, 1).Insert(in1, temp1.ToString());
//        num = num.Remove(in2, 1).Insert(in2, temp2.ToString());

//        Console.WriteLine(num);
//    }


//}


//task5
//Console.WriteLine("Task5");
//Console.WriteLine("Input your date like DD.MM.YYYY");

//string date = Console.ReadLine();
//if (date != null && date.Length == 10)
//{
//    string day = date.Substring(0, 2);
//    string month = date.Substring(3, 2);
//    string year = date.Substring(6, 4);
//    string str = "";
//    if (int.Parse(day) > 31 || int.Parse(day) < 0 || int.Parse(month) > 12 || int.Parse(month) < 0)
//    {
//        Console.WriteLine("Error!Wrond date value!");
//    }
//    else
//    {
//        string season = "";
//        switch (int.Parse(month))
//        {
//            case 12:
//            case 1:
//            case 2:
//                {
//                    season = "Winter";
//                    break;
//                }
//            case 3:
//            case 4:
//            case 5:
//                {
//                    season = "Spring";
//                    break;
//                }
//            case 6:
//            case 7:
//            case 8:
//                {
//                    season = "Summer";
//                    break;
//                }
//            case 9:
//            case 10:
//            case 11:
//                {
//                    season = "Autumn";
//                    break;
//                }
//        }
//        Console.WriteLine($"{season} {year}");


//    }



//}

//task6
//Console.WriteLine("Task6");
//Console.WriteLine("What type of temp? C or F");
//string flag=Console.ReadLine();

//if (flag ==null ||(flag !="C" && flag != "F"))
//{
//    Console.WriteLine("Error!");
//}
//else
//{
//    Console.WriteLine("Input temp");
//    double temp = int.Parse(Console.ReadLine());
//    Console.WriteLine("Input morph type C or F");
//    string sigh = Console.ReadLine();
//    if ((sigh == null) || (flag != "C" && flag != "F")){
//        Console.WriteLine("Error!");
//    }else if (sigh == "C" && flag == "F")
//    {
//       temp= (temp - 32) / 1.8;
//    }
//    else if(sigh == "F" && flag == "C")
//    {
//        temp = temp * 1.8 + 32;
//    }
//    Console.WriteLine(temp);
//}
//task7
Console.WriteLine("Task7");
Console.WriteLine("What type first num");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("What type second num");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
for (int i = num1; i <= num2; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
