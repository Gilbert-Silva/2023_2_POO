using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome");
    string s = Console.ReadLine();
    Console.WriteLine(s);
    s = StringUtils.FormatarEspacos(s);
    Console.WriteLine(s);
    s = StringUtils.FormatarIniciais(s);
    Console.WriteLine(s);
  }
}

class StringUtils {
  public static string FormatarIniciais(string texto) {
    texto = texto.ToLower();
    string[] v = texto.Split();
    string r = "";
    foreach (string p in v) 
      if (p == "e" || p == "da" || p == "de" || p == "do" ||
          p == "das" || p == "dos")
        r += p + " ";
      else
        r += char.ToUpper(p[0]) + p.Remove(0, 1) + " ";
    return r;
  }
  public static string FormatarEspacos(string texto) {
    texto = texto.Trim();
    int p = texto.IndexOf("  ");
    while (p != -1) {
      texto = texto.Remove(p, 1);
      p = texto.IndexOf("  ");
    }
    return texto;
  }
}