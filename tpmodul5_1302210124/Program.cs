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
        DataGeneric<long> objData = new DataGeneric<long>(1302210124);
        objData.printData();
    }
}

public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T inputAngka)
    {
        data = inputAngka;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

