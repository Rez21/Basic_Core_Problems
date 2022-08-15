namespace Basic_Core_Problems {


    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Problems");
            Console.WriteLine("Enter a number to select Problem");
            Console.WriteLine("1.Coin Flip Problem");
            Console.WriteLine("2.Leap Year Problem");

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

            }

        }
    }

}


   
