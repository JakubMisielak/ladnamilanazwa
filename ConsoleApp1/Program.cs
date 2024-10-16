class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("podaj znak")
            string podznak = Console.ReadLine();
        int a = 1;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        while (a < 100)
        {
            a++;
            Console.WriteLine(a);
        }
        foreach (char b in podznak)
        {
            Console.WriteLine(b);
        }
    }
}