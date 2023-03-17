using AssignmentLibrary;
using System;

class Assignment1
{
    static void findCube()
    {
        Console.WriteLine("Please enter no. to find its Cube: ");

        string choice = Console.ReadLine();
        int number;
        bool isConversionSuccessful = int.TryParse(choice, out number);
        if( isConversionSuccessful)
        {
            Console.WriteLine("The Cube of {0} is {1}", number, Helper.cubeOf(number));
        }
        else
        {
            Console.WriteLine("Please Type Only Integer Value.");
            switchCases(1);

        }


    }

    static void displayTable()
    {
        Console.WriteLine("Please enter number upto which you want to display table: ");

        string choice = Console.ReadLine();
        int numbers;
        bool isConversionSuccessful = int.TryParse(choice, out numbers);
        if (isConversionSuccessful )
        {
            if (choice.Length >= 3)
            {
                Console.WriteLine("\nThat will be too long. Below displayed till 10th.\n");
                Helper.ShowTable(10);
            }
            else
            {
                int number;
                if (int.TryParse(choice, out number))
                {
                    if (number <= 10) { Helper.ShowTable(number); }
                    else
                    {
                        Console.WriteLine("\nThat will be too long. Below displayed till 10th.\n");
                        Helper.ShowTable(10);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Please Type Only Integer Value.");
            switchCases(2);

        }

    }

    static void eligibleToVote()
    {
        Console.WriteLine("Please Enter your age to know if you're eligible to cast vote or not: ");

        
        string choice = Console.ReadLine();
        int age;
        bool isConversionSuccessful = int.TryParse(choice, out age);
        if (isConversionSuccessful )
        {
            bool isEligible = Helper.isEligibleForVote(age);
            if (isEligible) { Console.WriteLine(" Congratulations! you're eligible..."); }
            else { Console.WriteLine(" Sorry, you're cannot cast vote..."); }
        }
        else
        {
            Console.WriteLine("Age only consists of Integer .");
            switchCases(3);

        }

        
    }

    static void eligibleForAdmission()
    {
        Console.WriteLine("Please Enter your Maths Score: ");
        float mathScore = float.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter your Physics Score: ");
        float phyScore = float.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter your Chemistry Score: ");
        float chemScore = float.Parse(Console.ReadLine());

        bool isEligible =Helper.isEligibleForAdmission(mathScore, phyScore, chemScore);

        if(isEligible) { Console.WriteLine(" Hurray!, You can take admission..."); }
        else { Console.WriteLine(" sorry!, Better Luck next time..."); }
    }

    static void switchCases(int choice)
    {
        switch (choice)
        {
            case 1:
                findCube();
                break;

            case 2:
                displayTable();
                break;

            case 3:
                eligibleToVote();
                break;

            case 4:
                eligibleForAdmission();
                break;

            case 5:
                Console.WriteLine("\tSee you Next Time...");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("\tInvalid input. Choose from 1 to 5:\n");
                displayMenu();
                break;
        }

    }
    static void displayMenu()
    {
        Console.WriteLine("\n 1. Find Cube: ");
        Console.WriteLine(" 2. Display Multiplication-Table. ");
        Console.WriteLine(" 3. Eligible to Cast Vote? ");
        Console.WriteLine(" 4. Eligible for Admission? ");
        Console.WriteLine(" 5. Press 5 to quit. ");
        Console.WriteLine("\nChoose from 1 to 5:");

        string choice = Console.ReadLine();

        int number;
        if (int.TryParse(choice, out number))
        {
            switchCases(number);
        }
        else
        {
            Console.WriteLine(" Please Press Valid integer Key ( 1 to 5).");
            displayMenu();

        }

        

        Console.WriteLine("\n\tDo you Want to use Other Options (Y for yes, else any key): ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        
        char wanted = keyInfo.KeyChar;
        
        if (wanted =='Y' || wanted == 'y') { displayMenu(); }
        else { Environment.Exit(0); }
    }

    public static void Main(String[] args)
    {
        displayMenu();   
        
    }
}
