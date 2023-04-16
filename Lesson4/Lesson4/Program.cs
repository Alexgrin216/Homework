using Lesson4;

public class Programm
{
    public static void Main()
    {
        Counter counter = new Counter();
        Handler1 h1 = new Handler1();
        Handler2 h2 = new Handler2();
        counter.Catch += h1.Message;
        counter.Catch += h2.Message;
        counter.Count();
    }
}