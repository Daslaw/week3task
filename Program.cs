using System;

namespace week3task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Prime Number Testing @WellaSchool"); // Welcome to Prime Number Testing @WellaSchool
            Console.Write("Enter Your Number : ");
            int num= int.Parse(Console.ReadLine()); //readline() is used to read the input from the user
            int num2=0; //num2 is used to check if the number is prime or not
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                num2++;
                }
            }
            if (num2 == 2) { //if the number is prime
                Console.WriteLine("It's a Prime Number", num2); //It's a Prime Number @WellaSchool
            } else {
                Console.WriteLine("Not a Prime Number");//Not a Prime Number @WellaSchool
            }
            Console.ReadLine(); 

         } // end of main method
    } //Thank you for checking
} // WellaSchool Project by Daslaw
