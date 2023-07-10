using _06Methods;

internal class Program
{
    private static void Main(string[] args)
    {
        Student ferdi = new Student();
        ferdi.HelloStuName("Feridun");
        Selamla();

        int num2 = 0;
        RefTypeVal(ref num2);
        Console.WriteLine(num2);

        CWAlternate(Sum(4, 5, 6));
        Console.ReadKey();
    }

    static void Selamla()
    {
        Console.WriteLine("Hey There");
    }

    static void RefTypeVal(ref int num1)
    {
        num1 = 23;
    }

    static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;
    }

    static void CWAlternate(object o)
    {
        Console.WriteLine(o);
    }

}