using System;

namespace CS336
{
    public class Assignment4
    {
        static Boolean acceptable; //Is the birthday acceptable?
        static int age = 0;
        static String sign;

        public static void Main(String[] args)
        {
            Boolean repeat = true;
            while (repeat)
            {
                Console.Write("Please enter the year of your birth: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the month you were born: ");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter your birthday: ");
                int day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                var birthday = new DateTime(year, month, day);  //Passes arguments to birthday var
                CalculateAge(birthday);

                if (acceptable)
                {
                    if (DateTime.Now.DayOfYear == birthday.DayOfYear)   //Checks fir birthday
                    {
                        Console.WriteLine("HAPPY BIRTHDAY!!!!!");
                    }
                    Console.WriteLine("{0} {1} {2}", "You are ", age, " years old."); //Display Age
                    Console.WriteLine("Your Astrological Sign is {0}", getSign(month, day));   //Display Sign
                }
                else
                {
                    Console.WriteLine("Impossible Age! Try again");
                }

                //Repeat Program
                Console.Write("Again? 'Y' to repeat, 'N' to close: ");
                String ans = Console.ReadLine();
                if (ans.Equals("Y") || ans.Equals("y"))
                {
                    goto label;
                }
                else if (ans.Equals("N") || ans.Equals("n"))
                {
                    //repeat = false;
                    Environment.Exit(0);
                }
            label:
                Console.WriteLine("\n\n");
            }
        }

        //Method to calculate birthday
        public static int CalculateAge(DateTime birthday)
        {
            age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age--;
            if (birthday > DateTime.Now || age > 100)
                acceptable = false;
            else
                acceptable = true;

            return age;
        }

        //Method to get sign
        public static String getSign(int month, int day)
        {
            switch (month)
            {
                case 01:
                    if (day <= 20)
                    { sign = "Capricorn"; }
                    else
                    { sign = "Aquarius"; }
                    break;
                case 02:
                    if (day <= 19)
                    { sign = "Aquarius"; }
                    else
                    { sign = "Pisces"; }
                    break;
                case 03:
                    if (day <= 20)
                    { sign = "Pisces"; }
                    else
                    { sign = "Aries"; }
                    break;
                case 04:
                    if (day <= 20)
                    { sign = "Aries"; }
                    else
                    { sign = "Taurus"; }
                    break;
                case 05:
                    if (day <= 21)
                    { sign = "Taurus"; }
                    else
                    { sign = "Gemini"; }
                    break;
                case 06:
                    if (day <= 22)
                    { sign = "Gemini"; }
                    else
                    { sign = "Cancer"; }
                    break;
                case 07:
                    if (day <= 22)
                    { sign = "Cancer"; }
                    else
                    { sign = "Leo"; }
                    break;
                case 08:
                    if (day <= 23)
                    { sign = "Leo"; }
                    else
                    { sign = "Virgo"; }
                    break;
                case 09:
                    if (day <= 23)
                    { sign = "Virgo"; }
                    else
                    { sign = "Libra"; }
                    month = 9;
                    break;
                case 10:
                    if (day <= 23)
                    { sign = "Libra"; }
                    else
                    { sign = "Scorpio"; }
                    break;
                case 11:
                    if (day <= 22)
                    { sign = "Scorpio"; }
                    else
                    { sign = "Sagittarius"; }
                    break;
                case 12:
                    if (day <= 21)
                    { sign = "Sagittarius"; }
                    else
                    { sign = "Capricorn"; }
                    break;
                default:
                    sign = "Unknown";
                    break;
            }
            return sign;
        }
    }

}
