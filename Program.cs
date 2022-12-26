using Bai5;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Number of Customer: ");
        int n = int.Parse(Console.ReadLine());
        Hotel[] hotels = new Hotel[n];
        int HotelLength = hotels.Length;
        int CustomerLength = n;
        for(int i = 0; i < HotelLength; i++)
        {
            hotels[i] = new Hotel(); 
            Console.Write("Check in: ");
            int yearin = int.Parse(Console.ReadLine());
            int monthin = int.Parse(Console.ReadLine());
            int dayin = int.Parse(Console.ReadLine());
            DateTime checkin = new DateTime(yearin, monthin, dayin);
            int yearout = int.Parse(Console.ReadLine());
            int monthout = int.Parse(Console.ReadLine());
            int dayout = int.Parse(Console.ReadLine());
            DateTime checkout = new DateTime(yearout, monthout, dayout);
            Console.Write("Pick Room: ");
            char room = char.Parse(Console.ReadLine());
            hotels[i].Input(checkin, checkout, room);

            Customer[] customers = new Customer[CustomerLength];
            for(int j = 0; j < n; j++){
                customers[j] = new Customer();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                customers[j].InputCustomer(name, age, id);
            }
            hotels[i].InputForCustomer(customers);
        }
        for(int i = 0; i < HotelLength; i++)
        {
            hotels[i].Output();
        }

    }
}
