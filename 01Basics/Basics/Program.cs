internal class Program
{
    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {
            // ITS COMPLETED !!
            /*
            Console.WriteLine("Welcome!");
            Console.Write("Your Name: ");
            string userName = Console.ReadLine();
            Console.Write("Your Surname: ");
            string userSurName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Surname: " + userSurName);
            */

            /*
            string sent1 = "100";
            string sent2 = "heyyo";
            int num1 = int.Parse(sent1); //dont use it!
            int num2 = Convert.ToInt32(sent1); //the best one :)
           
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            */

            string sent1 = "True";
            bool convertToByteSent1 = Convert.ToBoolean(sent1);
            //Console.WriteLine(convertToByteSent1);

            int s1 = 100;
            byte convS1 = (byte)s1;
            float convFloS1= s1;

            //Console.WriteLine(convS1);
            //Console.WriteLine(convFloS1);
            /*
            byte b1 = 10;
            decimal convDecB1 = b1;
            Console.WriteLine(convDecB1);

            Console.ReadLine();
            */
        }
    }
}