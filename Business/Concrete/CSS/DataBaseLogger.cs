using Business.Concrete.CSS;
using System;

public class DataBaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Veritabanına loglandı");
    }
}




