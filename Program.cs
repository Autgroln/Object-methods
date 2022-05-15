using System;

namespace Object_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student student1 = new Student("Malina Firet", "Art", 3.6);
            Student student2 = new Student("Kaloyan Bazenikov", "Games", 4.6);

            Console.WriteLine("First student statement: ");
            string fstat = Console.ReadLine();

            Console.WriteLine("Second student statement: ");
            string sstat = Console.ReadLine();

            Console.WriteLine(student1.name);
            Console.WriteLine(student2.name);


            Console.WriteLine(student1.name + " " + fstat + "                         -" + student1.HasHoner());
            Console.WriteLine(student2.name + " " + sstat + "                         -" + student2.HasHoner());
            Console.ReadLine();*/

            Console.WriteLine("Choose a name for your character: Malina or  Kaloyan ");
            string name = Console.ReadLine();
                                               /*if (name == "Malina Firet")
                                        {
                                                      string rname1 = "Malina Firet";
                    
                                      } else
                                       {
                                              string rname2 = "Kaloyan Bazenikov";
                                      }*/




                                  //Така от горе са само тестове на кодове. Това от долъ е самият код! Всичко е описано вътре в  него. 



            

            switch (name)
            {
                case "Malina":
                    Console.WriteLine("Your character is Malina. She is 24 years old. Think before using her abilities, because she is very dangerous");
                    Console.WriteLine("Now choose her weapon:    Sword or Axe");
                    string weapon1 = Console.ReadLine();
                    if (weapon1 == "Sword")
                    {
                        Console.WriteLine("Nice one. Swords are very easy to use and hurt someone.");
                        Console.WriteLine("Once you have choosen the the best weapon for you, you are ready to go and fight. ");
                        Console.WriteLine("Now we'll see what you'll fight");
                        Console.WriteLine("Choose: Zombie or Dinasour");
                        
                        string enemies = Console.ReadLine();

                        Console.WriteLine("So the enemie you have choosen is weaker, and you win. Now you are ready for round 2");

                    }
                    else
                    {
                        Console.WriteLine("Bad decesion. Axe is very heavy to use.");
                        Console.WriteLine("Once you have choosen the the best weapon for you, you are ready to go and fight. ");
                        Console.WriteLine("Now we'll see what you'll fight");
                        Console.WriteLine("Choose: Zombie or Dinasour");

                        string enemies = Console.ReadLine();

                        if (enemies == "Zombie")
                        {
                            Console.WriteLine("You die! The game is over!");

                        }else if (enemies == "Dinasour")
                        {
                            Console.WriteLine("You win!");

                        }
                    }

                    break;
                case "Kaloyan":
                    Console.WriteLine("Your character is Kaloyan, 16 years old. Be careful with him..");
                    Console.WriteLine("Now choose him a weapon:   Pistol or AK-47 ");
                    string weapon2 = Console.ReadLine();
                    if (weapon2 == "AK-47")
                    {
                        Console.WriteLine("COOL! The greatest one. ");
                        Console.WriteLine("Once you have choosen the the best weapon for you, you are ready to go and fight. ");
                        Console.WriteLine("Now we'll see what you'll fight");
                        Console.WriteLine("Choose:    Tapaci or Idioti");
                        string enemies2 = Console.ReadLine();
                        Console.WriteLine("You have choosen the best weapon in the level! Do you really think you'll lose?     You win, next level!");
                    }
                    else
                    {
                        Console.WriteLine("Oooh Pistol, really?");
                        Console.WriteLine("Once you have choosen the the best weapon for you, you are ready to go and fight. ");
                        Console.WriteLine("Now we'll see what you'll fight");
                        Console.WriteLine("Choose:    Tapaci or Idioti");
                        string enemies2 = Console.ReadLine();
                        if (enemies2 == "Tapaci")
                        {
                            Console.WriteLine("The Tapaci are weak, so with the pistol you have a chance. You win! ");

                        }else if (enemies2 == "Idioti")
                        {
                            Console.WriteLine("Idiotite are very strong and dumb, you will die! The game is over");

                        }


                    }


                    break;


            }

            Console.WriteLine("Round 2 soon.... BYEEEE");
            
        }

    }
}
