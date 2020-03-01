using System;


namespace Military_Unit__Implementing_Inheritance_
{
    class Program
    {
        static void Main()
        {
            
            //Objects Section

            Assault_Rifle m16 = new Assault_Rifle();
            Knife knife = new Knife();
            Operations_Equipment oe = new Operations_Equipment();
            Communications_Equipment radio = new Communications_Equipment();
            Personal_Gear p_gear = new Personal_Gear();

            //Mission
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Do you want to be an officer or enlisted?\n" +
                "[1] Officer \n" +
                "[2] Enlisted \n");
            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    OfficerRoute();
                }

                else if (choice == 2)
                {
                    EnlistedRoute();
                }
                else
                {
                    Console.WriteLine("Try again\n");
                    Main();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }


            void EnlistedRoute()
            {
                Console.Clear();
                Enlisted enlisted = new Enlisted();
                
                Console.WriteLine($"{enlisted.Setting()}\n(You snap out as you hear yelling....\n" +
                    $"Sgt Motivation: Hey {name}. Didn't you hear me?\n" +
                    $"{enlisted.Mission1()}\n" +
                    $"What will you do?\n" +
                    "[1] Fix your uniform\n" +
                    "[2] Get your weapons\n" +
                    "[3] Grab your gear\n" +
                    "[4] Run to formation\n" +
                    "[5] 'Roger Sgt, I'll get it done'\n");

                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 5)
                {
                    Console.WriteLine("You run towards the place where you have all of your things.\n" +
                        "On your way there you spot your Captain....\n" +
                        "[1] Stop and salute.\n" +
                        "[2] Keep running towards your things\n");
                    int pick = int.Parse(Console.ReadLine());
                    if (pick == 1)
                    {
                        Console.WriteLine(enlisted.Greet());
                        Console.Clear();
                        Console.WriteLine($"Captain: Hello {name}. " +
                            "Make sure you grab everything you need!\n\n" +
                            "You approach your belongings....");
                        DisplayObjects();
                        int choice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        DescribeObjectsE(choice);
                    }
                    else if (pick == 2)
                    {
                        Console.WriteLine(enlisted.Correction2());
                        Console.ReadKey();
                        EnlistedRoute();
                    }
                }
                else
                {
                    Console.WriteLine(enlisted.Correction());
                    Console.ReadKey();
                    EnlistedRoute();
                }
            }

            void OfficerRoute()
            {
                Console.Clear();
                Officer officer = new Officer();
                Console.WriteLine(officer.Setting());
                Console.WriteLine(officer.Mission1());
                Console.ReadKey(); Console.Clear();

                Console.WriteLine($"{officer.Greet()} \n " +
                    $"Sgt Motivation: Captain {name}, I know we have a mission to accomplish.\n" +
                    "What do you need us to do?\n\n" +
                    "(Tell Sgt Motivation what to do):\n" +
                    "[1] I need everyone formed up with all of their weapons and gear.\n" +
                    "[2] Send everybody home.");

                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"I will be inspecting the unit after you tell me they are ready.\n" +
                        $"Sgt Motivation: Roger Captain, {officer.Greet()}, I'll get it done.\n");

                    Console.WriteLine($"Sgt Motivator leaves your presence to prepare the unit, you start preparing as well.");
                    DisplayObjects();
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    DescribeObjects(choice);
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Colonel Eagle: You failed me, your unit, and your country.\n" +
                        "[1] Try again\n" +
                        "[2] Exit Game\n");

                    int tryExit = int.Parse(Console.ReadLine());
                    if (tryExit == 1)
                    {
                        OfficerRoute();
                    }
                    else if (tryExit == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {

                    }


                }
            }


            void DisplayObjects()// displays all the non-personnel objects to the character with the option to see what it can do.
            {
                Console.WriteLine($"What do you want to see?\n" +
                   $"[1] Personal Gear\n" +
                   $"[2] M16\n" +
                   $"[3] Radio\n" +
                   $"[4] Knife\n" +
                   $"[5] Operations Equipment\n" +
                   $"[6] Grab everything.\n");
            }

            void DescribeObjects(int option)
            {
                
                switch (option)
                {
                    case (1):
                        Console.WriteLine(p_gear.Description());
                        Console.ReadKey();
                        OfficerRoute();
                        break;

                    case (2):
                        Console.WriteLine(m16.Description());
                        Console.ReadKey();
                        OfficerRoute();
                        break;

                    case (3):
                        Console.WriteLine(radio.Description());
                        Console.ReadKey();
                        OfficerRoute();
                        break;

                    case (4):
                        Console.WriteLine(knife.Description());
                        Console.ReadKey();
                        OfficerRoute();
                        break;

                    case (5):
                        Console.WriteLine(oe.Description());
                        Console.ReadKey();
                        OfficerRoute();
                        break;
                    case (6):
                        Officer officer = new Officer();
                        Console.WriteLine(officer.EndSetting());
                        Console.ReadKey();
                        break;
                }

            }

            void DescribeObjectsE(int option)
            {

                switch (option)
                {
                    case (1):
                        Console.WriteLine(p_gear.Description());
                        Console.ReadKey();
                        EnlistedRoute();
                        break;

                    case (2):
                        Console.WriteLine(m16.Description());
                        Console.ReadKey();
                        EnlistedRoute();
                        break;

                    case (3):
                        Console.WriteLine(radio.Description());
                        Console.ReadKey();
                        EnlistedRoute();
                        break;

                    case (4):
                        Console.WriteLine(knife.Description());
                        Console.ReadKey();
                        EnlistedRoute();
                        break;

                    case (5):
                        Console.WriteLine(oe.Description());
                        Console.ReadKey();
                        EnlistedRoute();
                        break;
                    case (6):
                        Enlisted enlisted = new Enlisted();
                        Console.WriteLine(enlisted.EndSetting());
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}