using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();
    // while (!s.Equals("*")) { // s.equals("*")
    while (s != "*") { 
      s = s.ToUpper();
      char c = s[0];
      bool t = true;
      for (int i = 0; i < s.Length; i++)
        if (s[i] == ' ' && s[i+1] != c) {
          t = false;
          break;
        }
      if (t) Console.WriteLine("Y");
      else Console.WriteLine("N");
      s = Console.ReadLine();
    }
  }
}
  