using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //ArrayList 
        /*
        ArrayList A1 = new ArrayList();
        A1.Add("Ferdi Bayram");
        A1.Add(29);
        
        ArrayList A2 = new ArrayList();
        A2.Add("İstanbul");
        A2.Add(34);

        A1.AddRange(A2);

        //foreach (var i in A1)
        //    Console.WriteLine(i);

        // Sort an ArrayList from Z-A 

        ArrayList a3 = new ArrayList();
        a3.Add("Kasım");
        a3.Add("Aliye");
        a3.Add("Ferdi");
        a3.Add("Harun");
        a3.Add("Hülya");
        a3.Add("Hamide");
        a3.Add("Şevval");

        a3.Sort();
        a3.Reverse();

        foreach (object i in a3)
            Console.WriteLine(i);
        */


        Hashtable H1 = new Hashtable();
        H1.Add("isim", "ferdi");
        H1.Add("şehir", "istanbul");
        H1.Add("araba", "toyota");

        Console.ReadKey();
    }
}