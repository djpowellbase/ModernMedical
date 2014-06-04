using System;

namespace ModernMedical
{
    class Program
    {
        const int three = 3;
        const int five = 5;
        const string modern = "Modern";
        const string medical = "Medical";

        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetDivisionOutput(i));
            }
        }

        private static string GetDivisionOutput(int curNumber)
        {
            var number = curNumber;
            
            if(((number % three) == 0) && ((number % five) == 0)) return modern + medical;

            if(((number % three) != 0) && ((number % five) != 0)) return number.ToString();

            return (number % three) == 0 ? modern : medical;
            
        }
    }

}
