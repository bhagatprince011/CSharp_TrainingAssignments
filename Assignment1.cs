﻿using AssignmentLibrary;
using System;

class Assignment1
{
    static void findCube()
    {
        Console.WriteLine(" Please enter no. to find its Cube: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The Cube of {0} is {1}",number,Helper.cubeOf(number));

    }

    static void displayTable()
    {
        Console.WriteLine(" Please enter number upto which you want to display table: ");
        int number = int.Parse(Console.ReadLine());
        Helper.ShowTable(number);

    }

    static void eligibleToVote()
    {
        Console.WriteLine(" Please Enter your age to know if you're eligible to cast vote or not: ");
        int age = int.Parse(Console.ReadLine());
        bool isEligible = Helper.isEligibleForVote(age);

        if(isEligible) { Console.WriteLine(" Congratulations! you're eligible..."); }
        else { Console.WriteLine(" Sorry, you're cannot cast vote..."); }
    }

    static void eligibleForAdmission()
    {
        Console.WriteLine(" Please Enter your Maths Score: ");
        float mathScore = float.Parse(Console.ReadLine());
        Console.WriteLine(" Please Enter your Physics Score: ");
        float phyScore = float.Parse(Console.ReadLine());
        Console.WriteLine(" Please Enter your Chemistry Score: ");
        float chemScore = float.Parse(Console.ReadLine());

        bool isEligible =Helper.isEligibleForAdmission(mathScore, phyScore, chemScore);

        if(isEligible) { Console.WriteLine(" Hurray!, You can take admission..."); }
        else { Console.WriteLine("sorry!, Better Luck next time..."); }
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
                Console.WriteLine(" See you Next Time...");
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
        Console.WriteLine(" 1. Find Cube: ");
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