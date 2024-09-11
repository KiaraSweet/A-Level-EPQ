using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EPQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Main menu: ");
            Console.WriteLine();
            Console.WriteLine("Which skill would you like to work on?");
            Console.WriteLine("1. Spelling");
            Console.WriteLine("2. Maths");
            Console.WriteLine("3. Memory");
            Console.WriteLine("4. Quit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Spelling();
            }
            else if (choice == 2)
            {
                Maths();
            }
            else if (choice == 3)
            {
                Memory();
            }
            else if (choice == 4)
            {

            }
        }
        static void Spelling()
        {
            int choice;
            Console.WriteLine("You are now doing spellings");
            Console.WriteLine();
            Console.WriteLine("length of words? 3 - 7 ");
            int length = int.Parse(Console.ReadLine());
            if (length == 3)
            {
                ThreeLetters();
            }
            else if (length == 4)
            {
                FourLetters();
            }
            else if (length == 5)
            {
                FiveLetters();
            }
            else if (length == 6)
            {
                SixLetters();
            }
            else if (length == 7)
            {
                SevenLetters();
            }
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("1. Main menu");
            Console.WriteLine("2. New word length");
            Console.WriteLine("3. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            else if (choice == 2)
            {
                Spelling();
            }
            else
            {

            }
        }
        static void Maths()
        {
            Console.WriteLine("Maths menu: ");
            Console.WriteLine();
            Console.WriteLine("Which skill would you like to work on?");
            Console.WriteLine("1. times tables");
            Console.WriteLine("2. percentages");
            Console.WriteLine("3. meanings of signs");
            Console.WriteLine("4. websites for help");
            Console.WriteLine("5. addition");
            Console.WriteLine("6. subtraction");
            Console.WriteLine("7. meaning of words");
            Console.WriteLine("8. videos for help");
            Console.WriteLine("9. Quit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    timesTables();
                    break;
                case 2:
                    percentages();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine(" +    this means you add the numbers");
                    Console.WriteLine(" -    this means you take away the numbers");
                    Console.WriteLine(" x    this means you times the numbers");
                    Console.WriteLine(" %    this means the number is a percentage");
                    Console.WriteLine(" =    this means the answer of the question is...");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("What would you like to do: ");
                    Console.WriteLine("1. Main menu");
                    Console.WriteLine("2. Maths menu");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Menu();
                    }  
                    else if (choice == 2)
                    {
                        Maths();
                    }
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Here are some websites that can help explain. Type the website into google and it will be the first link.");
                    Console.WriteLine();
                    Console.WriteLine("addition:  Addition - Maths is fun");
                    Console.WriteLine();
                    Console.WriteLine("subtraction:  Subtraction - Maths is fun");
                    Console.WriteLine();
                    Console.WriteLine("muliplication: what is multiplication splash learn");
                    Console.WriteLine();
                    Console.WriteLine("percentages: percentages maths is fun");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do: ");
                    Console.WriteLine("1. Main menu");
                    Console.WriteLine("2. Maths menu");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Menu();
                    }
                    else if (choice == 2)
                    {
                        Maths();
                    }
                    break;
                case 5:
                    Addition();
                    break;
                case 6:
                    Subtraction();
                    break;
                case 7:
                    Meanings();
                    break;
                case 8:
                    Console.WriteLine();
                    Console.WriteLine("Here are some videos that can help explain. Type the website into google and it will be the first link.");
                    Console.WriteLine();
                    Console.WriteLine("addition:  Addition - Maths is fun");
                    Console.WriteLine("subtraction:  Subtraction - Maths is fun");
                    Console.WriteLine("multiplication: multiply by repeated addition maggie");
                    Console.WriteLine("percentages: intro to percentages video");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do: ");
                    Console.WriteLine("1. Main menu");
                    Console.WriteLine("2. Maths menu");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Menu();
                    }
                    else if (choice == 2)
                    {
                        Maths();
                    }
                    break;
                case 9:
                    break;
            }
        }
        static void timesTables()
        {
            Console.WriteLine("You are now doing times tables");
            Console.WriteLine();
            Random r = new Random();
            int num1 = 0;
            int num2 = 0;
            int ans;
            int PAns;
            Console.WriteLine("which would you like to do?");
            Console.WriteLine("1. 2 times tables");
            Console.WriteLine("2. 3 times tables");
            Console.WriteLine("3. 4 times tables");
            Console.WriteLine("4. 5 times tables");
            Console.WriteLine("5. 6 times tables");
            Console.WriteLine("6. 7 times tables");
            Console.WriteLine("7. 8 times tables");
            Console.WriteLine("8. 9 times tables");
            Console.WriteLine("9. 10 times tables");
            Console.WriteLine("10. 11 times tables");
            Console.WriteLine("11. 12 times tables");
            Console.WriteLine("12. mix of all of the above");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice == 12)
            {
                for (int i = 0; i < 12; i++)
                {
                    num1 = r.Next(1, 12);
                    num2 = r.Next(1, 12);
                    do
                    {
                        Console.WriteLine(num1 + " x " + num2 + " =  ? ");
                        PAns = int.Parse(Console.ReadLine());
                        ans = num1 * num2;
                        if (ans == PAns)
                        {
                            Console.WriteLine("Well done! That was correct!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry! Try again.");
                            Console.ReadLine();
                        }
                    }
                    while (ans != PAns);
                }
                Console.WriteLine();
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Main menu");
                Console.WriteLine("2. times table menu");
                Console.WriteLine("3. Maths menu");
                Console.WriteLine("4. Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Menu();
                }
                else if (choice == 2)
                {
                    timesTables();
                }
                else if (choice == 3)
                {
                    Maths();
                }
                else if (choice == 4)
                {

                }
            }
            else
            {
                if (choice == 1)
                {
                    num1 = 2;
                }
                else if (choice == 2)
                {
                    num1 = 3;
                }
                else if (choice == 3)
                {
                    num1 = 4;
                }
                else if (choice == 4)
                {
                    num1 = 5;
                }
                else if (choice == 5)
                {
                    num1 = 6;
                }
                else if (choice == 6)
                {
                    num1 = 7;
                }
                else if (choice == 7)
                {
                    num1 = 8;
                }
                else if (choice == 8)
                {
                    num1 = 9;
                }
                else if (choice == 9)
                {
                    num1 = 10;
                }
                else if (choice == 10)
                {
                    num1 = 11;
                }
                else if (choice == 11)
                {
                    num1 = 12;
                }
                for (int i = 0; i < 12; i++)
                {
                    num2 += 1;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine(num1 + " x " + num2 + " =  ? ");
                        PAns = int.Parse(Console.ReadLine());
                        ans = num1 * num2;
                        if (ans == PAns)
                        {
                            Console.WriteLine("Well done! That was correct!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry! Try again.");
                            Console.ReadLine();
                        }
                    }
                    while (ans != PAns);
                }
                Console.WriteLine();
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Main menu");
                Console.WriteLine("2. times table menu");
                Console.WriteLine("3. Maths menu");
                Console.WriteLine("4. Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Menu();
                }
                else if (choice == 2)
                {
                    timesTables();
                }
                else if (choice == 3)
                {
                    Maths();
                }
                else if (choice == 4)
                {

                }
            }
        }
        static void percentages()
        {
            Console.WriteLine();
            Console.WriteLine("You are now doing percentages");
            Console.WriteLine();
            int choice;
            Console.WriteLine("Which do you want to do?");
            Console.WriteLine("1. how to");
            Console.WriteLine("2. questions");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("To work out a percentage you have to apply this method:");
                Console.WriteLine();
                Console.WriteLine("the percentage you want");
                Console.WriteLine("------------------------        x the total number");
                Console.WriteLine("         100");
                Console.WriteLine();
                Console.WriteLine("For example:");
                Console.WriteLine();
                Console.WriteLine("15% 0f 200 is?");
                Console.WriteLine("15/100  x 200 = 30");
                Console.WriteLine("The answer is 30.");
            }
            else if (choice == 2)
            {
                Random r = new Random();
                int num1 = 0;
                int num2 = 0;
                decimal ans;
                decimal PAns;
                Console.Clear();
                num1 = r.Next(1, 100);
                num2 = r.Next(1, 100);
                do
                {
                    num2 = r.Next(1, 100);
                }
                while (num1 >= num2);
                do
                {
                     decimal number1 = num1;
                     decimal number2 = num2; ;
                     Console.WriteLine("What is " + num1 + "% of " + num2);
                     PAns = decimal.Parse(Console.ReadLine());
                     ans = (number1 / 100) * number2;
                     if (ans == PAns)
                     {
                         Console.WriteLine("Well done! That was correct!");
                         Console.ReadLine();
                     }
                     else
                     {
                         Console.WriteLine("Sorry! Try again");
                         Console.ReadLine();
                     }
                }
                while (ans != PAns);
            }

            Console.WriteLine();
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("1. Main menu");
            Console.WriteLine("2. percentages menu");
            Console.WriteLine("3. Maths menu");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            else if (choice == 2)
            {
                percentages();
            }
            else if (choice == 3)
            {
                Maths();
            }
            else if (choice == 4)
            {

            }
        }
        static void Memory()
        {
            int choice;
            Console.WriteLine("You are now doing memory tests");
            Console.WriteLine();
            Console.WriteLine("Which test would you like?");
            Console.WriteLine("1. Remeber the objects");
            Console.WriteLine("2. Remeber the pattern");
            Console.WriteLine("3. What's missing?");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                RemObjects();
            }
            else if (choice == 2)
            {
                Pattern();
            }
            else if (choice == 3)
            {
                Missing();
            }
            else if (choice == 4)
            {

            }
        }
        static void Addition()
        {
            Console.WriteLine("You are now doing addition");
            Console.WriteLine();
            int choice;
            Console.WriteLine("Which do you want to do?");
            Console.WriteLine("1. how to");
            Console.WriteLine("2. questions");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int ans;
                Console.WriteLine();
                Console.WriteLine("When your adding you are working out how many there are.");
                Console.WriteLine("E.g. the total number of dots on a dice");
                Console.WriteLine("Try counting the number of dots on these two die");
                Console.WriteLine(" ______________              ______________");
                Console.WriteLine("|              |            |              |");
                Console.WriteLine("|  O           |            |  O        O  |");
                Console.WriteLine("|              |            |              |");
                Console.WriteLine("|              |            |       O      |");
                Console.WriteLine("|              |            |              |");
                Console.WriteLine("|           O  |            |  O        O  |");
                Console.WriteLine(" ______________              ______________");
                Console.WriteLine("How many dots are on the first dice?");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine("How many dots are on the second dice?");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine("How many dots are there in total? - on the first dice and the second dice");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine("Therefore");
                Console.WriteLine(" 2 + 5 = 7 ");
                Console.ReadLine();
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Main menu");
                Console.WriteLine("2. addition menu");
                Console.WriteLine("3. Maths menu");
                Console.WriteLine("4. Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Menu();
                }
                else if (choice == 2)
                {
                    Addition();
                }
                else if (choice == 3)
                {
                    Maths();
                }
                else if (choice == 4)
                {

                }
            }
            else if (choice == 2)
            {
                int num1 = 0;
                int num2 = 0;
                int PAns = 0;
                int answer = 0;
                Random r = new Random();
                int questions;
                Console.WriteLine("How many questions would you like?");
                questions = int.Parse(Console.ReadLine());
                Console.WriteLine("biggest possible number to add?");
                int biggest = int.Parse(Console.ReadLine());
                for (int i = 0; i < questions; i++)
                {
                    num1 = r.Next(0, biggest);
                    num2 = r.Next(0, biggest);
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine(num1 + " + " + num2 + " = ? ");
                        PAns = int.Parse(Console.ReadLine());
                        answer = num1 + num2;
                        if (answer == PAns)
                        {
                            Console.WriteLine("Well done! That was correct!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry! Try again.");
                            Console.ReadLine();
                        }
                    }
                    while (PAns != answer);
                }
                Console.WriteLine();
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Main menu");
                Console.WriteLine("2. addition menu");
                Console.WriteLine("3. Maths menu");
                Console.WriteLine("4. Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Menu();
                }
                else if (choice == 2)
                {
                    Addition();
                }
                else if (choice == 3)
                {
                    Maths();
                }
                else if (choice == 4)
                {

                }
            }
        }
        static void Subtraction()
        {
            Console.WriteLine("You are now doing subtraction");
            Console.WriteLine();
            int choice;
            Console.WriteLine("Which do you want to do?");
            Console.WriteLine("1. how to");
            Console.WriteLine("2. questions");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int ans;
                Console.WriteLine();
                Console.WriteLine("When you are subtracting you are working out the new total once something has been taken away");
                Console.WriteLine("E.g. the total number of dots on a dice");
                Console.WriteLine(" ______________");
                Console.WriteLine("|              |"); 
                Console.WriteLine("|  O        O  |");
                Console.WriteLine("|              |");
                Console.WriteLine("|  O        O  |");
                Console.WriteLine("|              |");
                Console.WriteLine("|  O        O  |");
                Console.WriteLine(" ______________");
                Console.WriteLine("How many dots are there on this dice?");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine("Now cover up 2 of the dots with your hands or highlight them with the mouse"); ;
                Console.WriteLine("How many dots are there on the dice now?");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine("Therefore");
                Console.WriteLine(" 6 - 2 = 4 ");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Main menu");
                Console.WriteLine("2. subtraction menu");
                Console.WriteLine("3. Maths menu");
                Console.WriteLine("4. Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Menu();
                }
                else if (choice == 2)
                {
                    Subtraction();
                }
                else if (choice == 3)
                {
                    Maths();
                }
                else if (choice == 4)
                {

                }
            }
            else if (choice == 2)
            {
                int num1 = 0;
                int num2 = 0;
                int PAns = 0;
                int answer = 0;
                Random r = new Random();
                int questions;
                Console.WriteLine();
                Console.WriteLine("How many questions would you like?");
                questions = int.Parse(Console.ReadLine());
                Console.WriteLine("biggest possible number to take away from?");
                int biggest = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i < questions; i++)
                {
                    num1 = r.Next(0, biggest);
                    num2 = r.Next(0, biggest);
                    do
                    {
                        do
                        {
                            if (num1 > num2)
                            {
                                Console.WriteLine(num1 + " - " + num2 + " = ? ");
                                PAns = int.Parse(Console.ReadLine());
                                answer = num1 - num2;
                                if (answer == PAns)
                                {
                                    Console.WriteLine("Well done! That was correct!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry! Try again.");
                                    Console.ReadLine();
                                }
                            }
                            else if (num2 > num1)
                            {
                                Console.WriteLine(num2 + " - " + num1 + " = ? ");
                                PAns = int.Parse(Console.ReadLine());
                                answer = num2 - num1;
                                if (answer == PAns)
                                {
                                    Console.WriteLine("Well done! That was correct!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Sorry! Try again.");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                num1 = r.Next(0, biggest);
                                num2 = r.Next(0, biggest);
                            }
                        }
                        while (num1 == num2);
                    }
                    while (PAns != answer);
                }
                Console.WriteLine();
                Console.WriteLine("What would you like to do: ");
                Console.WriteLine("1. Main menu");
                Console.WriteLine("2. subtraction menu");
                Console.WriteLine("3. Maths menu");
                Console.WriteLine("4. Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Menu();
                }
                else if (choice == 2)
                {
                    Subtraction();
                }
                else if (choice == 3)
                {
                    Maths();
                }
                else if (choice == 4)
                {

                }
            }
        }
        static void Meanings()
        {
            int choice;
            Console.WriteLine();
            Console.WriteLine("There are lots of different ways of saying the same words in maths. This will help you know what they mean.");
            Console.WriteLine();
            Console.WriteLine("addition : ");
            Console.WriteLine("   - increase by");
            Console.WriteLine("   - more");
            Console.WriteLine("   - add");
            Console.WriteLine();
            Console.WriteLine("subtraction : ");
            Console.WriteLine("   - decrease by");
            Console.WriteLine("   - minus");
            Console.WriteLine("   - difference");
            Console.WriteLine("   - take away");
            Console.WriteLine("   - fewer");
            Console.WriteLine();
            Console.WriteLine("times : ");
            Console.WriteLine("   - multiplied by");
            Console.WriteLine("   - find the product");
            Console.WriteLine("   - multiply");
            Console.WriteLine();
            Console.WriteLine("numerals    means numbers");
            Console.WriteLine();
            Console.WriteLine("arithmetic   means maths");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("1. Main menu");
            Console.WriteLine("2. Maths menu");
            Console.WriteLine("3. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            else if (choice == 2)
            {
                Maths();
            }
            else if (choice == 3)
            {

            }
        }
        static void RemObjects()
        {
            int choice;
            bool correct = true;
            bool repeat = true;
            Console.WriteLine("You are now doing the remember object test");
            Console.WriteLine();
            do
            {
                Console.WriteLine("How many objects would you like to try to remember? Choose a number between 1 and 20");
                int num = int.Parse(Console.ReadLine());
                string[] Objects = new string[] { "pen", "apple", "computer", "truck", "rainbow", "book", "dog", "phone", "hat", "plant", "ant", "jar", "map", "present", "ring", "slipper", "tape", "moues", "watch", "chair"};
                Console.WriteLine("Your objects are:");
                Console.WriteLine();
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(Objects[i]);
                }
                Console.WriteLine();
                Console.WriteLine("When you're ready press the enter key");
                Console.ReadLine();
                Console.Clear();
                string[] ans = new string[num];
                for (int j = 0; j < num; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("What was the first object?");
                        ans[j] = Console.ReadLine();
                        if (ans[j] == Objects[j])
                        {
                            correct = true;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("Sorry! That was wrong!");
                            Console.ReadLine();
                        }
                    }
                    else if (j == num - 1)
                    {
                        Console.WriteLine("What was the last object?");
                        ans[j] = Console.ReadLine();
                        if (ans[j] == Objects[j])
                        {
                            correct = true;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("Sorry! That was wrong!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("What was the next object?");
                        ans[j] = Console.ReadLine();
                        if (ans[j] == Objects[j])
                        {
                            correct = true;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("Sorry! That was wrong!");
                            Console.ReadLine();
                        }
                    }
                }
                if (correct == true)
                {
                    Console.WriteLine("Well Done!");
                }
                Console.WriteLine("Would you like to try again?");
                repeat = bool.Parse(Console.ReadLine());
            }
            while (repeat == true);
            Console.WriteLine();
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("1. Main menu");
            Console.WriteLine("2. Memory tests");
            Console.WriteLine("3. Rember the objects");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            else if (choice == 2)
            {
                Memory();
            }
            else if (choice == 3)
            {
                RemObjects();
            }
            else if (choice == 4)
            {

            }
        }
        static void Pattern()
        {
            int choice;
            bool ready;
            bool repeat = true;
            int num;
            Random r = new Random();
            num = r.Next(0, 3);
            string[] patsH = new string[3];
            patsH[0] = "//,//,*//,//,";
            patsH[1] = "#.#.##.#.#.##.";
            patsH[2] = "*.,*./*.,*./*.,";
            string[] patsE = new string[3];
            patsE[0] = "/#/#/";
            patsE[1] = "..'..";
            patsE[2] = ":)";
            string[] patsM = new string[3];
            patsM[0] = ":) (:";
            patsM[1] = "!!@!!@!!@";
            patsM[2] = "~:~*~";
            Console.WriteLine("Which difficulty would you like to do?");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficulty = int.Parse(Console.ReadLine());
            if (difficulty == 1)
            {
                repeat = false;
                Console.WriteLine(patsE[num]);
                do
                {
                    if (repeat == true)
                    {
                        Console.WriteLine(patsE[num]);
                        repeat = false;
                    }
                    Console.WriteLine("if you are ready type true");
                    ready = bool.Parse(Console.ReadLine());
                    if (ready == true)
                    {
                        Console.Clear();
                    }
                    Console.WriteLine("What was the pattern?");
                    string ans = Console.ReadLine();
                    if (ans == patsE[num])
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Would you like to try again. If yes type true. If no type false");
                        repeat = bool.Parse(Console.ReadLine());
                    }
                }
                while (repeat == true);
            }
            else if (difficulty == 2)
            {
                repeat = false;
                Console.WriteLine(patsM[num]);
                do
                {
                    if (repeat == true)
                    {
                        Console.WriteLine(patsM[num]);
                        repeat = false;
                    }
                    Console.WriteLine("if you are ready type true");
                    ready = bool.Parse(Console.ReadLine());
                    if (ready == true)
                    {
                        Console.Clear();
                    }
                    Console.WriteLine("What was the pattern?");
                    string ans = Console.ReadLine();
                    if (ans == patsM[num])
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Would you like to try again. If yes type true. If no type false");
                        repeat = bool.Parse(Console.ReadLine());
                    }
                }
                while (repeat == true);
            }
            else if (difficulty == 3)
            {
                repeat = false;
                Console.WriteLine(patsH[num]);
                do
                {
                    if (repeat == true)
                    {
                        Console.WriteLine(patsH[num]);
                        repeat = false;
                    }
                    Console.WriteLine("if you are ready type true");
                    ready = bool.Parse(Console.ReadLine());
                    if (ready == true)
                    {
                        Console.Clear();
                    }
                    Console.WriteLine("What was the pattern?");
                    string ans = Console.ReadLine();
                    if (ans == patsH[num])
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Would you like to try again. If yes type true. If no type false");
                        repeat = bool.Parse(Console.ReadLine());
                    }
                }
                while (repeat == true);
            }
            Console.WriteLine();
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("1. Main menu");
            Console.WriteLine("2. Memory tests");
            Console.WriteLine("3. Rember the pattern");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            else if (choice == 2)
            {
                Memory();
            }
            else if (choice == 3)
            {
                Pattern();
            }
            else if (choice == 4)
            {

            }
        }
        static void Missing()
        {
            int choice;
            bool repeat = true;
            bool ready;
            string missing;
            Random r = new Random();
            Console.WriteLine("You are now doing the what's missing test");
            Console.WriteLine();
            Console.WriteLine("How many objects would you like to try to remember? Choose a number between 1 and 20");
            int num = int.Parse(Console.ReadLine());
            string[] Objects = new string[] { "pen", "apple", "computer", "truck", "rainbow", "book", "dog", "phone", "hat", "plant", "ant", "jar", "map", "present", "ring", "slipper", "tape", "moues", "watch", "chair" };
            do
            {
                repeat = false;

                Console.WriteLine("Your objects are:");
                Console.WriteLine();
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(Objects[i]);
                }
                Console.WriteLine();
                Console.WriteLine("if you are ready type true");
                ready = bool.Parse(Console.ReadLine());
                if (ready == true)
                {
                    Console.Clear();
                }
                Console.WriteLine("What is missing from the list below? Use lowercase letters only");
                missing = Objects[r.Next(0, num)];
                for (int i = 0; i < num; i++)
                {
                    if (Objects[i] != missing)
                    {
                        Console.WriteLine(Objects[i]);
                    }
                }
                string ans = Console.ReadLine().ToLower();
                if (ans == missing)
                {
                    Console.WriteLine("Well done!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry! Would you like to try again. If yes type true. If no type false");
                    repeat = bool.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            while (repeat == true);
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("1. Main menu");
            Console.WriteLine("2. Memory tests");
            Console.WriteLine("3. What's missing?");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Menu();
            }
            else if (choice == 2)
            {
                Memory();
            }
            else if (choice == 3)
            {
                Missing();
            }
            else if (choice == 4)
            {

            }
        }
        static void ThreeLetters()
        {
            Random r = new Random();
            string word = "";
            string sentence = "";
            string missing = "";
            bool attempts = true;
            bool repeat = true;
            int number;
            StreamReader WFile = new StreamReader("3 letter words.txt");
            StreamReader SFile = new StreamReader("3 letter sentences.txt");
            StreamReader MFile = new StreamReader("3 letter missing.txt");
            do
            {
                attempts = false;
                number = r.Next(1, 26);
                do
                {
                    Console.Clear();
                    repeat = false;
                    Console.WriteLine(" what letters are mising from the following word?");
                    Console.WriteLine(word = File.ReadLines("3 letter words.txt").Skip(number).Take(1).First());
                    Console.WriteLine("A sentence using the word: ");
                    Console.WriteLine(sentence = File.ReadLines("3 letter sentences.txt").Skip(number).Take(1).First());
                    string answer = Console.ReadLine();
                    if (answer == (missing = File.ReadLines("3 letter missing.txt").Skip(number).Take(1).First()))
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        repeat = true;
                    }
                    Console.ReadLine();
                }
                while (repeat == true);
                Console.WriteLine("Would you like to another word? If yes type true. If no type false.");
                attempts = bool.Parse(Console.ReadLine());
            }
            while (attempts == true);
        }
        static void FourLetters()
        {
            Random r = new Random();
            string word = "";
            string sentence = "";
            string missing = "";
            bool attempts = true;
            bool repeat = true;
            int number;
            StreamReader WFile = new StreamReader("4 letter words.txt");
            StreamReader SFile = new StreamReader("4 letter sentences.txt");
            StreamReader MFile = new StreamReader("4 letter missing.txt");
            do
            {
                attempts = false;
                number = r.Next(1, 25);
                do
                {
                    Console.Clear();
                    repeat = false;
                    Console.WriteLine(" what letters are mising from the following word?");
                    Console.WriteLine(word = File.ReadLines("4 letter words.txt").Skip(number).Take(1).First());
                    Console.WriteLine("A sentence using the word: ");
                    Console.WriteLine(sentence = File.ReadLines("4 letter sentences.txt").Skip(number).Take(1).First());
                    string answer = Console.ReadLine();
                    if (answer == (missing = File.ReadLines("4 letter missing.txt").Skip(number).Take(1).First()))
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        repeat = true;
                    }
                    Console.ReadLine();
                }
                while (repeat == true);
                Console.WriteLine("Would you like another word? If yes type true. If no type false.");
                attempts = bool.Parse(Console.ReadLine());
            }
            while (attempts == true);
        }
        static void FiveLetters()
        {
            Random r = new Random();
            string word = "";
            string sentence = "";
            string missing = "";
            bool attempts = true;
            bool repeat = true;
            int number;
            StreamReader WFile = new StreamReader("5 letter words.txt");
            StreamReader SFile = new StreamReader("5 letter sentences.txt");
            StreamReader MFile = new StreamReader("5 letter missing.txt");
            do
            {
                attempts = false;
                number = r.Next(1, 25);
                do
                {
                    Console.Clear();
                    repeat = false;
                    Console.WriteLine(" what letters are mising from the following word?");
                    Console.WriteLine(word = File.ReadLines("5 letter words.txt").Skip(number).Take(1).First());
                    Console.WriteLine("A sentence using the word: ");
                    Console.WriteLine(sentence = File.ReadLines("5 letter sentences.txt").Skip(number).Take(1).First());
                    string answer = Console.ReadLine();
                    if (answer == (missing = File.ReadLines("5 letter missing.txt").Skip(number).Take(1).First()))
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        repeat = true;
                    }
                    Console.ReadLine();
                }
                while (repeat == true);
                Console.WriteLine("Would you like another word? If yes type true. If no type false.");
                attempts = bool.Parse(Console.ReadLine());
            }
            while (attempts == true);
        }
        static void SixLetters()
        {
            Random r = new Random();
            string word = "";
            string sentence = "";
            string missing = "";
            bool attempts = true;
            bool repeat = true;
            int number;
            StreamReader WFile = new StreamReader("6 letter words.txt");
            StreamReader SFile = new StreamReader("6 letter sentences.txt");
            StreamReader MFile = new StreamReader("6 letter missing.txt");
            do
            {
                attempts = false;
                number = r.Next(1, 25);
                do
                {
                    Console.Clear();
                    repeat = false;
                    Console.WriteLine(" what letters are mising from the following word?");
                    Console.WriteLine(word = File.ReadLines("6 letter words.txt").Skip(number).Take(1).First());
                    Console.WriteLine("A sentence using the word: ");
                    Console.WriteLine(sentence = File.ReadLines("6 letter sentences.txt").Skip(number).Take(1).First());
                    string answer = Console.ReadLine();
                    if (answer == (missing = File.ReadLines("6 letter missing.txt").Skip(number).Take(1).First()))
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        repeat = true;
                    }
                    Console.ReadLine();
                }
                while (repeat == true);
                Console.WriteLine("Would you like another word? If yes type true. If no type false.");
                attempts = bool.Parse(Console.ReadLine());
            }
            while (attempts == true);
        }
        static void SevenLetters()
        {
            Random r = new Random();
            string word = "";
            string sentence = "";
            string missing = "";
            bool attempts = true;
            bool repeat = true;
            int number;
            StreamReader WFile = new StreamReader("7 letter words.txt");
            StreamReader SFile = new StreamReader("7 letter sentences.txt");
            StreamReader MFile = new StreamReader("7 letter missing.txt");
            do
            {
                attempts = false;
                number = r.Next(1, 25);
                do
                {
                    Console.Clear();
                    repeat = false;
                    Console.WriteLine(" what letters are mising from the following word?");
                    Console.WriteLine(word = File.ReadLines("7 letter words.txt").Skip(number).Take(1).First());
                    Console.WriteLine("A sentence using the word: ");
                    Console.WriteLine(sentence = File.ReadLines("7 letter sentences.txt").Skip(number).Take(1).First());
                    string answer = Console.ReadLine();
                    if (answer == (missing = File.ReadLines("7 letter missing.txt").Skip(number).Take(1).First()))
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                        repeat = true;
                    }
                    Console.ReadLine();
                }
                while (repeat == true);
                Console.WriteLine("Would you like another word? If yes type true. If no type false.");
                attempts = bool.Parse(Console.ReadLine());
            }
            while (attempts == true);
        }
       
    }
}