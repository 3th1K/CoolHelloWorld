using System;
using System.Text;

public class CoolHelloWorld(string word)
{
    private readonly string _word = word;
    private readonly char[] _wordAsCharArray = word.ToCharArray();

    public static void RewriteLine(int lineNumber, String newText)
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentLineCursor - lineNumber);
        Console.Write(newText); Console.WriteLine(new string(' ', Console.WindowWidth - newText.Length));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public void Execute()
    {
        StringBuilder a = new StringBuilder();
        int i = 0;
        int start = 44, end = 123;
        int letter = Random.Shared.Next(start, end);
        a.Append(' ');
        while (!a.ToString().Trim().Equals(_word))
        {
            a[i] = (char)letter;

            if (_wordAsCharArray[i] == ' ')
            {
                a[i] = ' ';
                i++;
                a.Append(' ');
                letter = Random.Shared.Next(start, end);
            }
            else if (_wordAsCharArray[i] == a[i])
            {
                i++;
                a.Append(' ');
                letter = Random.Shared.Next(start, end);
            }
            else
            {
                letter = Random.Shared.Next(start, end);
            }
            Console.WriteLine(a.ToString());
            Thread.Sleep(5);
        }
        Console.ReadLine();
    }

    public void Execute1()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        string a = "";
        int start = 97, end = 122;
        for (int i = 0; i < _wordAsCharArray.Length; i++)
        {
            if (_wordAsCharArray[i] == ' ')
            {
                a += _wordAsCharArray[i];
                //Console.WriteLine(a);
                RewriteLine(2, a);
                Thread.Sleep(100);
            }
            else
            {
                for (int j = start; j <= end; j++)
                {
                    if ((char)j == _wordAsCharArray[i])
                    {
                        a += _wordAsCharArray[i];
                        RewriteLine(1, a);
                        Thread.Sleep(100);
                        break;
                    }
                    else
                    {
                        //Console.TreatControlCAsInput
                        RewriteLine(2, "" + (char)j);
                        Thread.Sleep(100);
                    }
                }
            }
        }
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        CoolHelloWorld _coolHelloWorld = new CoolHelloWorld("HELLO WORLD");
        _coolHelloWorld.Execute();
    }
}