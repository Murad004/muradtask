using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomeTask
{
    class WorkMenu
    {


        public static void Start()
        {
            bool stm = true;
            bool stmstm = true;

            Card card1 = new Card
            {
                Pan = "4343545465657676",
                Pin = "2004",
                Cvc = 255,
                ExpiredTime = new DateTime(2023, 12, 12),
                Balance = 600
            };
            Card card2 = new Card
            {
                Pan = "2222333344445555",
                Pin = "2006",
                Cvc = 259,
                ExpiredTime = new DateTime(2023, 12, 12),
                Balance = 600
            };
            Card card3 = new Card
            {
                Pan = "1111555566667777",
                Pin = "2930",
                Cvc = 258,
                ExpiredTime = new DateTime(2023, 12, 12),
                Balance = 600
            };
            Card card4 = new Card
            {
                Pan = "2323343445456767",
                Pin = "2009",
                Cvc = 257,
                ExpiredTime = new DateTime(2023, 12, 12),
                Balance = 600
            };
            Card card5 = new Card
            {
                Pan = "9999888877776666",
                Pin = "2020",
                Cvc = 256,
                ExpiredTime = new DateTime(2023, 12, 12),
                Balance = 600
            };

            User user1 = new User
            {
                Name = "Murad",
                Surname = "Sadixov",
                creditCard = card1
            };
            User user2 = new User
            {
                Name = "Elxan",
                Surname = "Atayev",
                creditCard = card2
            };
            User user3 = new User
            {
                Name = "Eli",
                Surname = "Ibadzade",
                creditCard = card3
            };
            User user4 = new User
            {
                Name = "Tural",
                Surname = "Tahirli",
                creditCard = card4
            };
            User user5 = new User
            {
                Name = "Cavid",
                Surname = "Mehsumov",
                creditCard = card5
            };
            User[] users = new User[5] { user1, user2, user3, user4, user5 };

            ///////////////////////////////////////////



            while (stm)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\tWelcome\n\n");

                Console.Write("PIN : ");
                string pin = Console.ReadLine();
                Console.Clear();



                try
                {
                    if (Helper.CheckPin(pin))
                    {
                    foreach (var item in users)
                    {
                        try
                        {
                                if (Helper.checkPinCorIncor(users, pin))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Balance (1)");
                                    Console.WriteLine("Cash (2)");
                                    Console.WriteLine("Send money (3)");
                                    Console.WriteLine("Exit (4)");
                                    Console.Write("You choose : ");
                                    bool isInt = int.TryParse(Console.ReadLine(), out int choose);
                                    Console.Clear();
                                    if (choose == 1)
                                    {
                                        Console.WriteLine($"Name : {item.Name}");
                                        Console.WriteLine($"Surname : {item.Surname}");
                                        Console.WriteLine($"Your balance : {item.creditCard.Balance}");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine(DateTime.Now.ToLongTimeString());
                                        Console.WriteLine("\n\n\n");
                                    return;
                                    }
                                    else if (choose == 2)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("10 AZN");
                                        Console.WriteLine("20 AZN");
                                        Console.WriteLine("30 AZN");
                                        Console.WriteLine("40 AZN");
                                        Console.WriteLine("60 AZN");
                                        Console.WriteLine("70 AZN");
                                        Console.WriteLine("80 AZN");
                                        Console.WriteLine("90 AZN");
                                        Console.WriteLine("100 AZN");
                                        Console.WriteLine("You can write if you want.");
                                        Console.Write("Amount : ");
                                        bool isInt2 = int.TryParse(Console.ReadLine(), out int amount);
                                        Console.Clear();
                                        try
                                        {
                                            if (Helper.CheckChooseBalance(users, amount))
                                            {
                                                
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Sucsesfully!");
                                                    item.creditCard.Balance -= amount;
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"Name : {item.Name}");
                                                    Console.WriteLine($"Surname : {item.Surname}");
                                                    Console.WriteLine($"Reamining balance : {item.creditCard.Balance}");
                                                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                                                    Console.WriteLine("\n\n\n");

                                            return;

                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                    else if (choose == 3)
                                    {
                                        bool sendstm = true;
                                        while (sendstm)
                                        {
                                            Console.Write("Enter the PIN you want to send : ");
                                            string sendpin = Console.ReadLine();

                                            if (Helper.CheckPin(sendpin))
                                            {
                                                foreach (var item2 in users)
                                                {

                                                    if (sendpin == item2.creditCard.Pin)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("How much money do you want to send : ");
                                                        bool isAmint = int.TryParse(Console.ReadLine(), out int amsend);
                                                        if (amsend <= item.creditCard.Balance)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Sucsesfully");
                                                            item.creditCard.Balance -= amsend;
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine($"Remaining balance : {item.creditCard.Balance}");

                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Bele pinde kart yoxdur.");
                                                        break;
                                                    }



                                                }
                                            }
                                        }
                                    }
                                    else if (choose == 4)
                                    {
                                        return;
                                    }

                                }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }




                        }
                    }

                }
                catch (Exception ex)
                {
                Console.WriteLine(ex.Message);
                }
                
                {
                    }

            }
        }
    }
}