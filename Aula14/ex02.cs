using System;
using System.Globalization;
using System.Threading;
using System.Timers;

class Program {
  private static System.Timers.Timer aTimer;
  
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

    SetTimer();
    
    DateTime x = DateTime.Now;
    Console.WriteLine(x);
    TimeSpan t = new TimeSpan(0, 0, 30, 0);
    Console.WriteLine(t);
    x = x + t;
    Console.WriteLine(x);

    DateTime hoje = DateTime.Now;
    DateTime prova = DateTime.Parse("1/11/2023 12:00");
    TimeSpan dif = prova - hoje;
    Console.WriteLine(dif);
    Console.WriteLine(dif.Days + " dias");
    Console.WriteLine(dif.Hours + " horas");
    Console.WriteLine(dif.Minutes + " minutos");
    Console.WriteLine(dif.Seconds + " segundos");

    Console.ReadLine();
    aTimer.Stop();
    aTimer.Dispose();
  }

   private static void SetTimer()
   {
        // Create a timer with a one second interval.
      aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
      aTimer.Elapsed += OnTimedEvent;
      //aTimer.AutoReset = true;
      aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
      DateTime hoje = DateTime.Now;
      DateTime prova = DateTime.Parse("11/1/2023 12:00");
      TimeSpan dif = prova - hoje;
      Console.WriteLine(dif);
    }
}