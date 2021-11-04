
using System;
using System.Collections.Generic;
using System.Linq;

namespace codingChallenge // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //EXERCISE 1
                        double sum = 0.0;

                        //create a empty list containing all irreducible fractions
                        List<double> irreducible_fractions = new List<double>() { };

                        //all fractions that have numerator = 1 will be irreducible fractions
                        for (double denominator = 1; denominator < 10; denominator++)
                        {
                            double fraction = (1 / denominator);
                            string f = "1/" + denominator;
                            Console.Write(f + ", ");
                            irreducible_fractions.Add(fraction);
                        }

                        //numerator < 10, denominator < 10, numerator < denominator
                        for (double denominator = 9; denominator > 0; denominator--)
                        {
                            for (double numerator = 2; numerator < denominator; numerator++)
                            {
                                double fraction = numerator / denominator;

                                if (irreducible_fraction(numerator, denominator) == true)
                                {
                                    irreducible_fractions.Add(fraction);
                                    string f = Convert.ToString(numerator) + "/" + Convert.ToString(denominator);
                                    Console.Write(f + ", ");

                                }

                            }
                        }

                        //sum of all irreducible fractions
                        foreach (var n in irreducible_fractions)
                        {
                            sum += n;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Sum of all irreducible fractions is: " + sum);

            //EXERCISE 2
                        int input = Convert.ToInt32(Console.ReadLine());
                        int result;
                        if (OddorEven(input) == "even") result = input / 2;
                        else result = input * 3 + 1;
                        Console.WriteLine("collatz(" + input + ")" + "-->" + result);

                        while (result > 1)
                        {
                            int old_result = result;
                            if (OddorEven(result) == "even") result = result / 2;
                            else result = result * 3 + 1;

                            Console.WriteLine("collatz(" + old_result + ")" + "-->" + result);
                        }

        }

        //if the value is true, it means that the fraction is irreducible
        public static bool irreducible_fraction(double n, double d)
        {
            int count = 0;
            for (double j = 2; j < 10; j++)
            {
                if (n % j == 0 && d % j == 0) count += 1;
            }
            if (count == 0) return true;
            else return false;
        }
        //odd or even
        public static string OddorEven(int number)
        {
            if (number % 2 == 0) return "even";
            else return "odd";
        }
    }

}