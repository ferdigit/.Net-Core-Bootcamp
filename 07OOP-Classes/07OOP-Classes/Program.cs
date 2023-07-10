using _07OOP_Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer M1 = new Customer();

        //M1.TcNumber = "12343456567";
        //M1.name = "Ferdi";
        //M1.surname = "Bayram";
        //M1.gender = 70087034;

        //Customer M2 = M1;
        //M2.name = "Harun";

        //M1 = null;
        //M2 = null;

        // Garbage Collector is working 
        //string TcNumber2 = M1.TcNumber; //null ref. exception

        //Customer M3 = new Customer("11448874","hulya","bayram",77007001);
        //Console.WriteLine(M3.TcNumber);
        //Console.WriteLine(M3.name);
        //Console.WriteLine(M3.surname);
        //Console.WriteLine(M3.gender);

        //bool myControl = M3.CustomerControl();
        //Console.WriteLine(myControl);

        Car c1 = new Car("Toyota","Corolla",2020,12345.67,"petrol","automatic",22.345,27.456,3);
        c1.ShowInfo();
        Console.ReadKey();

    }
}