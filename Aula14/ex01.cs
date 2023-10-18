using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    
    DateTime x = DateTime.Now;
    Console.WriteLine(x);
    Console.WriteLine(x.ToString("dd/MM/yyyy"));
    Console.WriteLine(x.ToString("ddd/MMM/yy"));
    Console.WriteLine(x.ToString("dddd/MMMM/yy"));
    Console.WriteLine(x.ToString("dd/MM/yyyy hh:mm:ss"));
    Console.WriteLine(x.ToString("dddd, dd MMMM yyyy"));
    Console.WriteLine(x.Day);
    Console.WriteLine(x.Month);
    Console.WriteLine(x.Year);
    Console.WriteLine(x.DayOfWeek);
    x = x.AddMonths(1);
    Console.WriteLine(x);
    x = x.AddMonths(1);
    Console.WriteLine(x);
    x = x.AddMonths(1);
    Console.WriteLine(x);
    Console.WriteLine("Informe sua data de nascimento: dd/mm/aaaa");
    string s = Console.ReadLine();
    DateTime y = DateTime.Parse(s);
    Console.WriteLine(y);
    Console.WriteLine(y.Day);
    Console.WriteLine(y.Month);
    Console.WriteLine(y.Year);
    Console.WriteLine(y.DayOfWeek);


  }
}