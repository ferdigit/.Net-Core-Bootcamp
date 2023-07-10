using _08OOP_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer m1 = new Customer();
        m1.id = 1;
        m1.name = "Ferdi";
        m1.surName = "Bayram";

        //m1.email = "ferdib@hotmail.com";
        m1.Email = "ferdibay@hotmail.com";
        Console.WriteLine(m1.Email); 
        Console.ReadKey();
    }
}