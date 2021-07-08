using SecondModule;

public class Program
{
    public static void Main()
    {
	SecondModuleType secondModule = new SecondModuleType();
	string text = secondModule.Print(); 
        System.Console.WriteLine("Hello from the FirstModule!");
	System.Console.WriteLine(text);
        System.Console.ReadLine();
    }
}








