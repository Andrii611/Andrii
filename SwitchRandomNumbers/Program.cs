namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta numbrid");

            //genereerib iga kord suvalised numbrid
            //1-st kuni 6-ni
            
            //pete kasutama switchi, et igat numbrit näidata
;
            int number = new Random().Next(1,6);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Sistestasid number 1");
                    break;

                case 2:
                    Console.WriteLine("Sistestasid number 2");
                    break;

                case 3:
                    Console.WriteLine("Sistestasid number 3");
                    break;

                case 4:
                    Console.WriteLine("Sistestasid number 4");
                    break;

                case 5:
                    Console.WriteLine("Sistestasid number 5");
                    break;

                case 6:
                    Console.WriteLine("Sistestasid number 6");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
