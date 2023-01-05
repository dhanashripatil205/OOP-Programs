using InventoryManagementDeno;

namespace InventoryManagementDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to the Object Oriented Program *****");

            string path = "C:\\Users\\ganesh\\source\\repos\\InventoryManagementDeno\\InventoryManagementDeno\\Inventory.json";
            ReadData obj = new ReadData();
            var Info = obj.Read(path);

            //Console.WriteLine(Info.typesOfRice.name);
            //Console.WriteLine(Info.typesOfRice.weight);
            //Console.WriteLine(Info.typesOfRice.price);

            //Storing the multiple values of Array in List.
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Rice is:");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Info.typesOfRice.Count; i++)
            {
                Console.WriteLine(Info.typesOfRice[i].name);
                Console.WriteLine(Info.typesOfRice[i].weight);
                Console.WriteLine(Info.typesOfRice[i].price);

               
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Pulses is:");
            Console.WriteLine("--------------------");


            for (int i = 0; i < Info.typesOfPulses.Count; i++)
            {
                Console.WriteLine(Info.typesOfPulses[i].name);
                Console.WriteLine(Info.typesOfPulses[i].weight);
                Console.WriteLine(Info.typesOfPulses[i].price);

                

            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Wheat is:");
            Console.WriteLine("--------------------");

            for (int i = 0; i < Info.typesOfWheat.Count; i++)
            {
                Console.WriteLine(Info.typesOfWheat[i].name);
                Console.WriteLine(Info.typesOfWheat[i].weight);
                Console.WriteLine(Info.typesOfWheat[i].price);

                


            }
        }
    }
}