using System;
using System.Threading.Tasks;

namespace Sporting_Event
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            const int LIM = 0;
            int input_adult_ticket;
            int input_child_ticket;
            int input_senior_ticket;
            


            // Loop the input until the input is not non-negative. If the input is negative value, the program will ask you to input non-negative value until the input is non-negative. Otherwise it will keep asking to input non-negative value
            Console.WriteLine("----------------------------------------------Task 1----------------------------------------------");
            Console.WriteLine();
            Console.Write("Please input the number of children tickets>> ");
            input_child_ticket = Convert.ToInt32(Console.ReadLine());
            
            
            while (input_child_ticket < LIM)
            {
                Console.WriteLine();
                Console.Write($"Please input non-negative value for number of children tickets>> ");
                input_child_ticket = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine();
            Console.Write("Please input the number of adult tickets>> ");
            input_adult_ticket = Convert.ToInt32(Console.ReadLine());
            

            while (input_adult_ticket < LIM)
            {
                Console.WriteLine();
                Console.Write($"Please input non-negative value for number of adult tickets>> ");
                input_adult_ticket = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine();
            Console.Write("Please input the number of senior tickets>> ");
            input_senior_ticket = Convert.ToInt32(Console.ReadLine());
            
            while (input_senior_ticket < LIM)
            {
                Console.WriteLine();
                Console.Write($"Please input non-negative value for number of tickets>> ");
                input_senior_ticket = Convert.ToInt32(Console.ReadLine());                
            }
            
            Console.WriteLine();
            
            Console.WriteLine("----------------------------------------------Task 2-------------------------------------------");
            Console.WriteLine();
            const double adult_ticket_cost = 20.00;
            const double child_rate = 0.5;
            const double senior_rate = 0.75;
            //Calculate double child_ticket_cost variable by using * (multiply operator) with adult_ticket_cost and child_rate
            double child_ticket_cost = adult_ticket_cost * child_rate;
            //Calculate double senior_ticket_cost variable by using * (multiply operator) with adult_ticket_cost and senior_rate
            double senior_ticket_cost = adult_ticket_cost * senior_rate;
            //Calculate double total_adult_cost variable by using * (multiply operator) with adult_ticket_cost and input_adult_ticket
            double total_adult_cost = input_adult_ticket * adult_ticket_cost;
            //Calculate double total_child_cost variable by using * (multiply operator) with child_ticket_cost and input_child_ticket
            double total_child_cost = input_child_ticket * child_ticket_cost;
            //Calculate double total_senior_cost variable by using * (multiply operator) with senior_ticket_cost and input_senior_ticket
            double total_senior_cost = input_senior_ticket * senior_ticket_cost;
            //Calcaulate double total_cost variable by using + (plus operator) with total_adult_code, total_child_code and total_senior_code
            double total_cost = total_adult_cost + total_child_cost + total_senior_cost;
            // It's showing the input of task 1 for each ticket type
            Console.WriteLine($"Number of tickets for children is {input_child_ticket}, for adult is {input_adult_ticket} and for senior is {input_senior_ticket}");
            Console.WriteLine();
            Console.WriteLine($"Revenue from selling ticket is {total_cost:C}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------Task 3-------------------------------------------");
            Console.WriteLine();
            // Calculate the variable by using if statement with input_adult_ticket is less than or equal to Input_child_ticket plus input_senior_ticket, the program will show The event is becoming a festival for everyone!
            if (input_adult_ticket <= (input_child_ticket + input_senior_ticket))
            {
                Console.WriteLine("The event is becoming a festival for everyone!");
            }
            // 
            else if (input_child_ticket >= input_senior_ticket)
            {
                Console.WriteLine("The event is attracting more and more young people");
            }
            else
            {
                Console.WriteLine("The event should have more space for kids!");
            }
            Console.WriteLine();
            // If the user input the variable is not between 0 to 40.It is using while loop statement to ask the user until input the number is between 0 to 40.
            Console.WriteLine("----------------------------------------------Task 4-------------------------------------------");
            Console.WriteLine();
            const int MIN = 0;
            const int MAX = 40;
            int input_participants;
            Console.Write($"Enter number of participants >> ");
            input_participants = Convert.ToInt32(Console.ReadLine());
            while (input_participants < MIN || input_participants > MAX)
            {
                Console.WriteLine();
                Console.Write($"        Invalid value - Number must be between 0 and 40. Enter a valid value >> ");
                input_participants = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            // It is depends on the varible of task 4 input_participant to do the for loop statement
            // It will prompt the user and let them input the name and event code
            // If the user is not input a valid event code, it will ask user to input a valid event code
            // Calculate the total number input of each event code by using if and else if statement (input_event_code == SWIMMING_CODE) with total += input_event_code, ++count
            // Before the program end, it will show how many valid event code is inputed
            Console.WriteLine("----------------------------------------------Task 5-------------------------------------------");
            Console.WriteLine("Enter Participant information: ");
            Console.WriteLine();
            const char SWIMMING_CODE = 'S';
            const char BADMINTON_CODE = 'B';
            const char FOOTBALL_CODE = 'F';
            
            char input_event_code;
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            int total = 0;
            
            for (int i = LIM; i < input_participants; i++)
            {
                Console.Write($"Enter participant name >> ");
                string input_name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Event codes are:");
                Console.WriteLine("  S for Swimming");
                Console.WriteLine("  B for Batminton");
                Console.WriteLine("  F for Football");
                Console.Write($"        Enter event code for this participant >> ");
                input_event_code = Convert.ToChar(Console.ReadLine());

                
                while (input_event_code != SWIMMING_CODE && input_event_code != BADMINTON_CODE && input_event_code != FOOTBALL_CODE)
                {
                    
                    Console.WriteLine("        {0} is not a valid code", input_event_code);
                    Console.Write($"        Enter a valid event code >> ");
                    input_event_code = Convert.ToChar(Console.ReadLine());                    
                }
                if (input_event_code == SWIMMING_CODE)
                    {
                    total += input_event_code;
                        ++count;
                    }
                else if (input_event_code == BADMINTON_CODE)
                    {
                    total += input_event_code;
                        ++count1;
                    }
                else if (input_event_code == FOOTBALL_CODE)
                    {
                    total += input_event_code;
                        ++count2;
                    }

                
                Console.WriteLine();

            }
            Console.WriteLine("The total number of event code S is {0}, event code B is {1}, event code F is {2}", count, count1, count2);        
            
        }           
    }
}
