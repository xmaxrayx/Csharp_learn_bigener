// See https://aka.ms/new-console-template for more information



using System.Diagnostics;
Process.Start("F:\\SteamLibrary\\steamapps\\common\\Titanfall2\\Titanfall2Launcher.bat");
Console.WriteLine("start");
Console.WriteLine("Hello, World!");
Thread.Sleep(5000); //will sleep for 5 sec

Console.WriteLine("Hello, World!");
Console.ReadLine();

/*


class Program
{
    static void Main()
    {
        Process.Start(@"F:\SteamLibrary\steamapps\common\Titanfall2\Titanfall2Launcher.bat");
    }
}

*/


/*
{
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
    {
        Environment.Exit(0);
    }
}
*/
