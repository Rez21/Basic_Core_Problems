namespace Basic_Core_Problems {


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Problems");
            Console.WriteLine("Enter a number to select Problem");
            Console.WriteLine("1.Coin Flip Problem");
            Console.WriteLine("2.Leap Year Problem");
            Console.WriteLine("3. Power Of Two");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Factors of Number");
            Console.WriteLine("6. Compute Quotient & Remainder");
            Console.WriteLine("7. Even Or Odd Number");

            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    Coin_Flip toss = new Coin_Flip();
                    toss.CoinFlip();
                    break;
                case 2:
                    Leap_Year year = new Leap_Year();
                    year.LeapYearCheck();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.PowerTwo();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmoncValue();
                    break;
                case 5:
                    Factors fact = new Factors();   
                    fact.Factor();
                    break;
                case 6:
                    QuotientAndRemainder num = new QuotientAndRemainder();
                    num.QuotReminder();
                    break;
                case 7:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenOdd();
                    break;
            }

        }
    }

}


   
