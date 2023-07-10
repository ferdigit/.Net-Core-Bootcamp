internal class Program
{
    private static void Main(string[] args)
    {
        //string[] names = { "ferdi", "haru", "hulya", "hamide" }; //dynamic

        //string[] surNames = new string[4]; //static 
        //surNames[0] = "bayram";
        //surNames[1] = "ayran";
        //surNames[2] = "tepik";
        //Console.WriteLine(names[0] + "**");
        //Console.WriteLine(surNames[1] + "***");
        //Console.WriteLine("");
        //foreach (var i in names)
        //{
        //    Console.WriteLine(i);
        //}

        Random randomNumber = new Random();
        int numrnd = randomNumber.Next(1,20);
        Console.WriteLine(numrnd);
        Console.ReadKey();
    }
}