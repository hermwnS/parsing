internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Masukkan angka: ");
        string inputString = Console.ReadLine();
        try
        {
            int inputInt = Convert.ToInt32(inputString);
            Console.WriteLine(che(inputInt * inputInt));
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}