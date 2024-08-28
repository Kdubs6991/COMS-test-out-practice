using System.ComponentModel;

namespace TestOutPractice;

class Program
{
    static void Main(string[] args)
    {
        count_vowels();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        
        is_lucas_sequence();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        
        coffee_break();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        
        purpleOrNot();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        
        noConditions();
        
    }

    public static void count_vowels()
    {
        Console.WriteLine("Find out how many vowels are in a word.");
        Console.Write("Enter a word: ");
        string inputWord = Console.ReadLine();
        
        //Convert the word to all lowercase
        inputWord = inputWord.ToLower();
        char[] vowelsList = { 'a', 'e', 'i', 'o', 'u' };
        
        //List to count how many vowels
        List<char> foundVowels = new List<char>();
        
        int vowelCounter = 0;
        //Checking if there is a vowel in the word, if there is they get added to a list
        foreach (char letter in inputWord )
        {
            if (Array.Exists(vowelsList, vowel => vowel == letter))
            {
                foundVowels.Add(letter);
                vowelCounter++;
            }
        }
        Console.WriteLine("Found vowels: " + vowelCounter.ToString());
    }

    public static void is_lucas_sequence()
    {
        Console.WriteLine("Below enter 7 numbers to check if");
        Console.WriteLine("it is a lucas sequence.");
        Console.WriteLine("");
        
        //7 numerical inputs 
            
        Console.WriteLine("1st Number: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("2nd Number: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("3rd Number: ");
        int numberThree = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("4th Number: ");
        int numberFour = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("5th Number: ");
        int numberFive = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("6th Number: ");
        int numberSix = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("7th Number: ");
        int numberSeven = Convert.ToInt32(Console.ReadLine());

        bool answer;
        if (numberOne + numberTwo == numberThree)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        if (numberTwo + numberThree == numberFour)
        {
            if (answer == false)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
        }
        else
        {
            answer = false;
        }

        if (numberFour + numberFive == numberSix)
        {
            if (answer == false)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
        }
        else
        {
            answer = false;
        }

        if (numberSix + numberSeven == numberSeven)
        {
            if (answer == false)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
        }
        else
        {
            answer = false;
        }
        
        Console.WriteLine("The statement that your numbers are a Lucas sequence is " + answer);
    }

    public static void coffee_break()
    {
        //setting variables for prices
        int singleDoughnut = 1;
        int dozenDoughnut = 10;
        double oneCoffe = 1.5;
        
        
        Console.WriteLine("Prices:");
        Console.WriteLine("\tSingle Doughnut: $" + singleDoughnut);
        Console.WriteLine("\tOne Dozen Doughnuts: $" + dozenDoughnut);
        Console. WriteLine("\tOne Coffe: $" + oneCoffe);
        Console.WriteLine();
        //inputs and variables for them
        Console.WriteLine("How many doughnuts would you like?");
        int doughnutAmount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many coffee's would you like?");
        int coffeeAmount = Convert.ToInt32(Console.ReadLine());

        int amountOfDozens = 0;
        int amountOfFreeCoffe = 0;
        bool i = true;
        while (i == true)
        {
            if (doughnutAmount >= 12)
            {
                amountOfDozens++;
                doughnutAmount = doughnutAmount - 12;
            }
            else
            {
                i = false;
            }
        }

        if (amountOfDozens >= 1 && coffeeAmount >= 1)
        {
            for (int k = 0; amountOfDozens > k; k++)
            {
                amountOfFreeCoffe++;
                coffeeAmount--;
            }
        }

        double totalAmount = (amountOfDozens * dozenDoughnut) + (coffeeAmount * oneCoffe) + (doughnutAmount * singleDoughnut);
        
        Console.WriteLine("Total Amount: $" + totalAmount);
    }

    public static void purpleOrNot()
    {
        int maxNumber = 0;
        Random rnd = new Random();
        
        Console.WriteLine("What is the max number youd like to choose: ");
        maxNumber = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i <= maxNumber;)
        {
            int is_purple = rnd.Next(0, maxNumber);
            if (i == is_purple)
            {
                Console.WriteLine(i + " is purple");
                i++;
            }
            else
            {
                Console.WriteLine(i + " is not purple");
                i++;
            }
        }
    }

    public static void noConditions()
    {
        Console.WriteLine("what would you like your first number to be: ");
        int inputOne = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("what would you like your second number to be: ");
        int inputTwo = Convert.ToInt32(Console.ReadLine());

        
        bool answer = mystery(inputOne, inputTwo);
        static bool mystery(int x, int y)
        {
            return (x > y && y != 0) || x == 0;
        }
        Console.WriteLine("Result: " + answer);
    }

    public static void print_pattern()
    {
        Console.WriteLine("What would you like the max number to be: ");
        int maxNumber = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= maxNumber;i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}