using System;

namespace app4
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the action to be performed\n\n");
                Console.WriteLine("\nPress 1 for Login");
                Console.WriteLine("\nPress 2 for Signup");
             //   Console.WriteLine("Press 3 for Exit App");
                int userAction = int.Parse(Console.ReadLine());

                switch (userAction)
                {
                    case 1:
                        {
                            Login.StudentLogin();
                            break;
                        }

                    case 2:
                        {
                            SignUp.GetStudentData();
                            break;
                        }

                    /*case 3:
                        {
                            Console.WriteLine("\n\nThanks for using the App");
                            break;
                        }*/
                    default:
                        Console.WriteLine("Wrong Input. Please Enter Correct Input");
                        break;
                }
            }


        }
    }
}
