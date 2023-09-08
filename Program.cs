// 1. Leap Year

Console.WriteLine("Enter the Year");
int year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine($"The year: {year} is a Leap Year");
}
else
{
    Console.WriteLine("It is not Leap Year");
}

// 2. take 2 numbers and print the larger of the two numbers.
Console.WriteLine("Enter 2 numbers to check the larger of the 2");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("The larger Number is: " + Math.Max(n1, n2));
// or
if (n1 > n2)
{
    Console.WriteLine($"{n1} is greater");
}
else
{
    Console.WriteLine($"{n2} is greater");
}


// 3. Check for Vowels
// char only takes one key(1 char)
Console.WriteLine("Enter a Character");
char ch = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine(""); // To give an extra line
Console.WriteLine("Method 1");
if ("aeiou".Contains(ch))
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Constant");
}

// OR 
Console.WriteLine("Method 2");
if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Constant");
}

//4. Check if the number is positive, negative or zero
Console.WriteLine("Enter a number to check if it is positive or negative or zero");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("The number is Positive");
}
else if (number < 0)
{
    Console.WriteLine("The number is Negative");
}
else
{
    Console.WriteLine("The Number is zero");
}


// 5. Check the larger number out of 3
Console.WriteLine("Enter a number to get the larger of 3");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 >= num2)
{
    if (num1 >= num3)
    {
        Console.WriteLine($"{num1} is larger");
    }
    else
    {
        Console.WriteLine($"{num3} is larger");
    }
}
else
{
    if (num2 >= num3)
    {
        Console.WriteLine($"{num2} is greater");
    }
    else
    {
        Console.WriteLine($"{num3} is greater");
    }
}

// 6. Check if the number is divisible by 5 and 7
Console.WriteLine("Enter a number to check if the number is divisible by 5 and 7");
int num4 = int.Parse(Console.ReadLine());

if (num4 % 5 == 0 && num4 % 7 == 0)
{
    Console.WriteLine("The number is Divisible");
}
else
{
    Console.WriteLine("The number is not Divisible");
}

//7. CHeck if the number is similar, different or sum =100
Console.WriteLine("CHeck if the number is similar, different or sum =100");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine("Similar");
}
else if (n1 + n2 == 100)
{
    Console.WriteLine("Sum is equal to 100");
}
else
{
    Console.WriteLine("Different");
}

//8. Character to check if it is lower case, upper case or a digit

Console.WriteLine("Enter a character to check if it is lower case, upper case or a digit");
char check = Console.ReadKey().KeyChar;

Console.WriteLine(""); // Add a line in between

if (char.IsUpper(check))
{
    Console.WriteLine("The Character is Upper Case");    
}else if (char.IsLower(check))
{
    Console.WriteLine("The Character is Lower Case");    
}else if (char.IsDigit(check)) {
    Console.WriteLine("The Character is a Digit");
}
else
{
    Console.WriteLine("Some Other Character");
}

//9. To get 3 numbers and print them in ascending order.

Console.WriteLine("Enter 3 numbers to print them in Ascending Order");
num1 =  int.Parse(Console.ReadLine());
num2 =  int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());

if(num1 <= num2 && num1 <= num3) {
    Console.Write(num1 + ", ");
    if (num2 <= num3)
    {
        Console.WriteLine(num2 + ", " + num3);
    }
    else
    {
        Console.WriteLine(num3 + ", " + num2);
    }
} else if (num2 <= num1 && num2 <= num3)
{
    Console.Write(num2 + ", ");
    if (num1 <= num3)
    {
        Console.WriteLine(num1 + ", " + num3);
    }
    else
    {
        Console.WriteLine(num3 + ", " + num1);
    }
}
else
{
    Console.Write(num3 + ", ");
    if (num1 <= num2)
    {
        Console.WriteLine(num1 + ", " + num2);
    }
    else
    {
        Console.WriteLine(num2 + ", " + num1);
    }
}