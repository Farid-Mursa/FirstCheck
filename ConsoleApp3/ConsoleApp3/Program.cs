namespace ConsoleApp3
{
    internal class Program
    {
        public class SimCard
        {
            public string CarrierName { get; set; }
            public string Number { get; set; }
            public decimal Balance { get; set; }
            public decimal Tariff { get; set; }

            public void IncreaseBalance(decimal amount)
            {
                if (amount<=0)
                {
                    Console.WriteLine("elemede bele");
                    return;
                }
                Balance += amount;
            }
            public void Call(decimal amount)
            {
                if (amount <=0 || amount>Balance)
                {
                    Console.WriteLine("Balansinizda kifayet qeder mebleq yoxdur");
                    return;
                }
                if (Balance<0.20m)
                {
                    Console.WriteLine("Balansiniz sifra yaxinlashir");
                    Balance -= amount;
                    return;
                }
                Balance -= amount;
            }

        }
        public static void Main(string[] args)
        {
            SimCard card = new()
            {
                CarrierName = "Bakcell",
                Number = "+994557477743",
                Balance= 0.04m,
                Tariff=0.05m
            };

            

            Console.ForegroundColor = ConsoleColor.Magenta;
            //card.IncreaseBalance(1);
            card.Call(card.Tariff);
            Console.WriteLine(card.Balance);

        }
        
    }
}