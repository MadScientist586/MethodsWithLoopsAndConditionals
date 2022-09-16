

Console.WriteLine("LukeWarm Section");
Console.WriteLine("---------------------------------------------");
PrintRange(1000, -1000);


static void PrintRange(int num1,int num2)
{
    for (int i = num1; i >= num2; i--)
    {
        Console.WriteLine(i);
    }


}
Console.WriteLine("------------------------------------------------------------------");
PrintRange1(3, 999);


static void PrintRange1(int num1, int num2)
{
    for (int i = num1; i <= num2; i += 3)
    {
        Console.WriteLine(i);
    }


}

Console.WriteLine("Enter a number:");
var num1 = Console.ReadLine();
Console.WriteLine("Enter another number:");
var num2 = Console.ReadLine();

{  
    if (num1 == num2)
    {
       Console.WriteLine("These numbers are equal.");

    }

    else
    {
        Console.WriteLine("These numbers are not equal.");
    }
 }
Console.WriteLine("Enter a number, even or odd:");
var num = Convert.ToInt32(Console.ReadLine());
{
    if (num % 2 == 0)
    {
        Console.WriteLine("This number is even.");
    }
    else
    {
        Console.WriteLine("This number is odd");
    }
}

Console.WriteLine("Please enter a number, positive or negitive:");
var enter = Convert.ToInt32(Console.ReadLine());
{
    if (enter > 0)

    {
        Console.WriteLine("This number is positive.");
    }
    else if (enter == 0)
    {
        Console.WriteLine("This number is neither positive or negative.");
    }
    else
    {
        Console.WriteLine("This number is negative");
    }
}
Console.WriteLine("How old are you?");
var age = Convert.ToInt32(Console.ReadLine());
{
    if (age >= 18)
    {
        Console.WriteLine("You are old enough to vote");
    }
    else
    {
        Console.WriteLine("You are not old enough to vote");
    }
}

Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------------------------------------------");

Console.WriteLine("Heatin Up Section");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Please enter a number:");
var num6 = Convert.ToInt32(Console.ReadLine());
if (num6 <= 10 && num6 >= -10)
{
    Console.WriteLine("This number is in the range of -10 and 10.");
}
else
{
    Console.WriteLine("This number is not in the range of -10 and 10");
}
Console.WriteLine("Please enter a number:");
var num7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num7} * 1 ={num7 * 1}");
Console.WriteLine($"{num7} * 2 ={num7 * 2}");
Console.WriteLine($"{num7} * 3 ={num7 * 3}");
Console.WriteLine($"{num7} * 4 ={num7 * 4}");
Console.WriteLine($"{num7} * 5 ={num7 * 5}");
Console.WriteLine($"{num7} * 6 ={num7 * 6}");
Console.WriteLine($"{num7} * 7 ={num7 * 7}");
Console.WriteLine($"{num7} * 8 ={num7 * 8}");
Console.WriteLine($"{num7} * 9 ={num7 * 9}");
Console.WriteLine($"{num7} * 10 ={num7 * 10}");
Console.WriteLine($"{num7} * 11 ={num7 * 11}");
Console.WriteLine($"{num7} * 12 ={num7 * 12}");








