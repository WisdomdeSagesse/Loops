using System;

    class Program
    {
        static void Main()
        {

        /*
            Console.Write("Create a password: ");
            string password = Console.ReadLine();
            Console.Write("Repeat your password: ");
            string repeatPassword = Console.ReadLine();

        if (password != repeatPassword)
        {
            Console.Write("Create a password: ");
            password = Console.ReadLine();
            Console.Write("Repeat your password: ");
            repeatPassword = Console.ReadLine();
        }
        Console.WriteLine("Password Created Successfully");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        string actualPassword;

        do
        {
            Console.WriteLine("Enter password");
            actualPassword = Console.ReadLine();
        }
        while (password != actualPassword);

        Console.WriteLine("Log-in Successful");*/

        Console.Write("Create a password: ");
        string password = Console.ReadLine();
        Console.Write("Repeat your password: ");
        string repeatedPassword = Console.ReadLine();

        while (password != repeatedPassword)
        {
            Console.Write("Passwords do not match try again: ");
            password = Console.ReadLine();
            Console.Write("Repeat your password: ");
            repeatedPassword = Console.ReadLine();
        }
        Console.WriteLine("Password created successfully.");
        
        Console.WriteLine();
        Console.WriteLine();

        string enteredPassword;
        Console.WriteLine("Enter your password");
        enteredPassword = Console.ReadLine();

        while (password != enteredPassword)
        {
            Console.Write("Incorrect Password. Try again: ");
            enteredPassword= Console.ReadLine();
        }
        Console.WriteLine("Log-in Successful");
    }
    }

