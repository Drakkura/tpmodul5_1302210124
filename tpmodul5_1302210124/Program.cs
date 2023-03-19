internal class Program
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T input)
        {
            Console.WriteLine("Halo User " + input);
        }
    }
    public static void Main(string[] args)
    {
        HaloGeneric.sapaUser("Ryan");
    }
}