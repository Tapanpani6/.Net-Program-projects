using System;
using System.Collections.Immutable;
using System.Diagnostics.Tracing;

class Program
{
    public static void Main()
    {
        Program p = new Program();
        //p.fibonacci();
        //p.reverseNum();
        //p.PrimeNumber();
        //p.PalindromeNum();
        //p.ReverseString();
        //p.RemoveDuplicatechar();
        //p.Factorial();
        //p.SwapNum();
        //p.SwapNumWithoutThirdVariable();
        //p.SplitString();
        //p.ArrAyPractice();
        //p.ArrayAccess();
        //p.ArrUpperLower();
        //p.SplitMethod();
        //p.HalfDiamond();
        //p.Anagram();

        /*OverLoading_add a = new OverLoading_add();
        a.Add(10, 20);
        a.Add(10.5f, 20.5f);*/

        //Dog d = new Dog();
        //Dog.sleep();

        /*Monkey m = new Monkey();
        m.Eat();
        m.sleeping();
        m.Skill();*/
        //p.SecondLargestNum();
        //p.PrintStarPattern();
        //p.PrintFullStarPattern();
        //p.RemoveDuplicateNum();
        p.PrimeOneToTen();

    }
    public void fibonacci()
    {
        int a = 0;
        int b = 1;
        int c;
        for (int i = 0; i <= 10; i++)
        {
            c = a + b;
            Console.WriteLine("Fibonacci series is: " + c);
            a = b;
            b = c;
        }
    }
    public void reverseNum()
    {
        Console.WriteLine("Enater a number: ");
        int num;
        int rem;
        int res = 0;
        num = Convert.ToInt32(Console.ReadLine());
        while (num != 0)
        {
            rem = num % 10;
            res = res * 10 + rem;
            num = num / 10;
        }
        Console.WriteLine("Reverse of a number is: " + res);
    }
    public void PrimeNumber()
    {
        Console.WriteLine("Enter a number ");
        int num;
        int count = 0;
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine(num + " is a prime number");
        }
        else
        {
            Console.WriteLine(num + " is a prime number");

        }
    }
    public void PalindromeNum()
    {
        Console.WriteLine("Enter a number: ");
        int num;
        int rem;
        int res = 0;
        num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        while (num != 0)
        {
            rem = num % 10;
            res = res * 10 + rem;
            num = num / 10;
        }
        num = temp;
        if (res == num)
        {
            Console.WriteLine(num + " Is a Palindrome number");
        }
        else
        {
            Console.WriteLine(num + " is not a Palindrome number");
        }
    }
    public void ReverseString()
    {

        string str = "Tapan";
        string res = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            res = res + str[i];
        }
        Console.WriteLine("Reverse of a string is: " + res);
    }
    public void RemoveDuplicatechar()
    {
        string str = "Tapanpanigrahi";
        string res = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (!res.Contains(str[i]))
            {
                res = res + str[i];
            }
        }
        Console.WriteLine(res);
    }
    public void Factorial()
    {
        Console.WriteLine("Enter a number");
        int fact = 1;
        int num;
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("factrorial of " + num + " is " + fact);
    }
    public void SwapNum()
    {
        int a = 10; int b = 20;
        int c;
        Console.WriteLine("Before swapping a and b value, a is " + a + " b is " + b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After swapping a and b value, a is " + a + " b is " + b);

    }
    public void SwapNumWithoutThirdVariable()
    {
        int a = 10; int b = 20;
        Console.WriteLine("Before swapping a and b value, a is " + a + " b is " + b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After swapping a and b value, a is " + a + " b is " + b);

    }
    public void SplitString()
    {
        string str = "Tapan Kumar panigrahi";
        string[] res = str.Split(' ');
        foreach (string i in res)
        {
            Console.WriteLine(i);
        }
    }
    public void ArrAyPractice()
    {
        string[] name = { "Tapan", "Kuamr", "Panigrahi" };
        foreach (string i in name)
        {
            Console.WriteLine(i);
        }
    }
    public void ArrayAccess()
    {
        string[] cars = { "Tata", "Kuamr", "Hyundai" };
        cars[2] = "Ford";
        cars[0] = "Farrari";
        cars[1] = "Mustang";
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
    public void ArrUpperLower()
    {
        string name = "Tapan KumaR PaNiGrAHi";
        name = name.ToLower();
        Console.WriteLine(name);
        name = name.ToUpper();
        Console.WriteLine(name);

    }
    public void SplitMethod()
    {
        string x = "Tapan@KumaR@PaNiGrAHi";
        string[] str = x.Split('@');
        string res = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            res = res + str[i];
        }
        Console.WriteLine(res.ToLower());
    }
    public void HalfDiamond()
    {
        int num = 5;
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        for (int i = num - 1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    public void Anagram()
    {
        string a = "HeArt";
        string b = "EarTh";

        a = a.ToLower();
        char[] x = a.ToCharArray();
        Array.Sort(x);

        b = b.ToLower();
        char[] y = b.ToCharArray();
        Array.Sort(y);

        if (x.Length == y.Length)
        {
            Console.WriteLine("Both the strings are Anagram");
        }
        else
        {
            Console.WriteLine("Both the strings are not Anagram");
        }
    }
    class OverLoading_add
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }

    class OverridingAnimal
    {
        public void sleep()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog : OverridingAnimal
    {
        public void sleep()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    class Inheri_Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
        public void sleeping()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
    class Monkey : Inheri_Animal
    {
        public void Skill()
        {
            Console.WriteLine("Monkey knows jumping");
        }
    }
    public void SecondLargestNum()
    {

        int num = 19583;
        char[] x = num.ToString().ToCharArray();
        Array.Sort(x);
        Console.WriteLine("Second largest number is " + x[x.Length - 2]);

    }
    public void PrintStarPattern()
    {
        int num = 5;
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
    public void PrintFullStarPattern()
    {

        int num = 5;
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for (int i = num - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
    public void RemoveDuplicateNum()
    {
        long num = 113535563354623;
        string str = num.ToString();
        string res = string.Empty;
        for (int i = 0; i <= str.Length - 1; i++)
        {
            if (!res.Contains(str[i]))
            {
                res = res + str[i];
            }
        }
        Console.WriteLine("after removing duplicate, the final numbers are " + res);
    }
    public void PrimeOneToTen()
    {
        int totalcount = 0;
        for (int num = 1; num <= 10; num++)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.Write(num+",");
                totalcount++;
            }
        }
        Console.WriteLine(" and total count is "+totalcount);

    }
}
