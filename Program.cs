using System.ComponentModel.Design; 

using System.Numerics; 

 

namespace Pizza_Challenge 

{ 

    internal class Program 

    { 

        static void Main(string[] args) 

        { 

            Console.WriteLine("How many pizzas would you like?"); 

            int num_pizzas = Convert.ToInt32(Console.ReadLine()); 

            double total_cost = 0.0; 

            bool valid; 

            for (int i = 0; i < num_pizzas; i++) 

            { 

 

                int[] topping_num = { 1, 2, 3, 4, 5 }; 

                Console.WriteLine("How many toppings would you like on your pizza?"); 

                int num_toppings = Convert.ToInt32(Console.ReadLine()); 

                int[] user_toppings = new int[num_toppings]; 

                for (int c = 0; c < num_toppings; c++) 

                { 

                    valid = false; 

                    Console.WriteLine($"Please enter the topping number of your {c+1}, topping."); 

                    Console.WriteLine("The topping numbers are as follows: 1=Cheese, 2=basil, 3=chicken, 4=sweetcorn, 5=olives"); 

                    int topping = Convert.ToInt32(Console.ReadLine()); 

                    foreach (int d in topping_num) 

                    { 

                        if (topping == d) 

                        { 

                            valid = true; 

                        } 

                        else 

                        { 

                            Console.WriteLine("You need to choose a pizaa toppping that is availlable"); 

                        } 

                    } 

          

 

                    foreach (int z in user_toppings) 

                    { 

                        if (z == topping) 

                        { 

                            Console.WriteLine("You have already chosen this topping - exit, come back to this program choose again"); 

                        } 

                        else 

                        { 

                            user_toppings[c] = topping; 

                        } 

                    } 

                    Console.WriteLine("What was the size of the pizza? 1=small 2=medium 3=large"); 

                    int size = Convert.ToInt32(Console.ReadLine()); 

                    double cost; 

                    if (size == 1) 

                    { 

                        cost = 2.50; 

                        cost = cost + (0.75 * (Convert.ToDouble(num_toppings))); 

                        Console.WriteLine($"The cost of your pizza is {cost}"); 

                        total_cost = total_cost + cost; 

                    } 

                    else if (size == 2) 

                    { 

                        cost = 4.50; 

                        cost = cost + (0.75 * (Convert.ToDouble(num_toppings))); 

                        Console.WriteLine($"The cost of your pizza is {cost}"); 

                        total_cost = total_cost + cost; 

                    } 

                    else if (size == 3) 

                    { 

                        cost = 7.25; 

                        cost = cost + (0.75 * (Convert.ToDouble(num_toppings))); 

                        Console.WriteLine($"The cost of your pizza is {cost}"); 

                        total_cost = total_cost + cost; 

                    } 

 

                } 

                Console.WriteLine($"The total cost of your order is {total_cost}"); 

                if (total_cost > 20) 

                { 

                    Console.WriteLine("You are eligible for a 10% discount"); 

                    total_cost = total_cost - (total_cost * 0.1); 

                    Console.WriteLine($"The total cost of your order with our discount is {total_cost}"); 

                } 

                Console.WriteLine("Do you need Delivery? - type y/n"); 

                string delivery = Console.ReadLine(); 

                if (delivery == "y" && total_cost < 25.0) 

                { 

                    total_cost = total_cost + 3.5; 

                    Console.WriteLine($"The total cost of your order with delivery is {total_cost}"); 

                } 

                else if (delivery == "n" && total_cost >= 25.0) 

                { 

                    Console.WriteLine("Your delivery will be free!"); 

                } 

 

            } 

        } 

    } 

} 
