using System;

class Program {
  public static void Main() {
    // 5 tipos básicos de dados
    int a = 5;
    double b = 2.5;
    char c = '1';
    string d = "Programação";
    bool e = true;
    Console.WriteLine(a);  // print
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);
    string s = Console.ReadLine();  // input
    Console.WriteLine(s + s);
    // i = int(input("Digite um inteiro"))
    Console.WriteLine("Digite um inteiro");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine(i + i);
    Console.WriteLine(1 + "abc");
    Console.WriteLine('1' + '1');
    Console.WriteLine("1" + "1");
    Console.WriteLine("1" + '1');
    double x = 1;      // Conversão implícita
    int y = (int) 1.5; // Conversão explícita
    Console.WriteLine(x);
    Console.WriteLine(y);
    // Conversão de texto em real
    /* 
    s = "10.23";
    double z = double.Parse(s);
    Console.WriteLine(z);
    */
    // Conversão de real em texto
    // z = 10.23
    // s = str(z)
    double z = 10.23;
    s = z.ToString();         // método de instância (var)
    Console.WriteLine(s + s); // método de classe (static)
    //x = []
    //x.append(10) - método da classe list
    //x.sort()
    
    

    
    
    
  }
}