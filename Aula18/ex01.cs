using System;
using System.Collections;

class Program {
  public static void Main() {
    ContaReceber c1 = new ContaReceber("Supermercado", DateTime.Parse("2023-10-05"), 1000, true);
    ContaReceber c2 = new ContaReceber("Clínica", DateTime.Parse("2024-01-03"), 8000, false);
    ContaReceber c3 = new ContaReceber("Escola Marista", DateTime.Parse("2023-12-15"), 3000, false);
    ContaReceber c4 = new ContaReceber("Escola CEI", DateTime.Parse("2023-12-15"), 5000, false);
    ContaReceber c5 = new ContaReceber("Hospital", DateTime.Parse("2023-12-15"), 2000, false);
    c2.Cliente = "Hospital";    //com propriedade
    // y.SetCliente("Hospital"); com método
    /*
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Console.WriteLine(x.CompareTo(y)); // -1   x é menor que y
    Console.WriteLine(y.CompareTo(z)); //  1   y é maior que z
    Console.WriteLine(y.CompareTo("Teste")); //  1   y é maior que z
    */
    Financeiro f = new Financeiro();
    f.Inserir(c1);
    f.Inserir(c2);
    f.Inserir(c3);
    f.Inserir(c4);
    f.Inserir(c5);
    foreach (ContaReceber c in f.Listar()) Console.WriteLine(c);
    foreach (ContaReceber c in f) Console.WriteLine(c);

    foreach (char l in "Teste") Console.WriteLine(l);

    IEnumerator it = f.GetEnumerator();
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    
    foreach (ContaReceber c in f.ContasRecebidas()) Console.WriteLine(c);

    /*
    ContaReceber[] v = { c1, c2, c3, c4, c5 };
    Array.Sort(v);
    foreach (ContaReceber c in v)
      Console.WriteLine(c);
    */
  }
}

// interface IComparable {
//   int CompareTo(object obj);
// }

class Financeiro : IEnumerable {
  private ContaReceber[] contas = new ContaReceber[10];
  private int k = 0;
  // CRUD - Create, Read, Update, Delete
  public void Inserir(ContaReceber conta) { // Create
    if (k < 10) contas[k++] = conta;
  }
  public ContaReceber[] Listar() { // Read
    ContaReceber[] aux = new ContaReceber[k];
    Array.Copy(contas, aux, k);
    // for (int i = 0; i < k; i++) aux[i] = contas[i];
    Array.Sort(aux);
    return aux;
  }
  public IEnumerator GetEnumerator() {
    //return contas.GetEnumerator();
    return Listar().GetEnumerator();
  }
  public ContaReceber[] ContasRecebidas() { 
    int qtd = 0;
    foreach(ContaReceber c in Listar()) if (c.Recebido) qtd++;
    ContaReceber[] aux = new ContaReceber[qtd];
    int i = 0;
    foreach(ContaReceber c in Listar()) if (c.Recebido) aux[i++] = c;
    Array.Sort(aux);
    return aux;
  }
}

class ContaReceber : IComparable {
  private string cliente;
  private DateTime dataVencimento;
  private double valor;
  private bool recebido;
  public ContaReceber(string cliente, DateTime data, double valor, bool recebido) {
    this.cliente = cliente;
    this.dataVencimento = data;
    this.valor = valor;
    this.recebido = recebido;
  }
  public int CompareTo(object obj) {
    // this quem chama o método
    // obj  quem é passado por parâmetro
    if (obj is ContaReceber) {
      ContaReceber r = (ContaReceber) obj; // type-cast
      // if (this.dataVencimento < r.dataVencimento) return -1;
      // if (this.dataVencimento == r.dataVencimento) return 0;
      // if (this.dataVencimento > r.dataVencimento) return 1;
      if (this.dataVencimento == r.dataVencimento) 
        return -this.valor.CompareTo(r.valor);
      return this.dataVencimento.CompareTo(r.dataVencimento);
      //return this.cliente.CompareTo(r.cliente);
  }
    return 0;  
  }
  public string Cliente {
    get { return cliente; }
    set { if(value != "") this.cliente = value;
      else this.cliente = "Cliente não informado"; }
  }
  public DateTime DataVencimento {
    get { return dataVencimento; }
    set { this.dataVencimento = value; }
  }
  public double Valor {
    get { return valor; }
    set { this.valor = value; }
  }
  public bool Recebido {
    get { return recebido; }
    set { this.recebido = value; }
  }
  public void Receber() {
    recebido = true;
  }
  public override string ToString() {
    if (recebido) return $"Recebida: {cliente} {dataVencimento:dd/MM/yyyy} {valor:f2}";
    return $"A receber: {cliente} {dataVencimento:dd/MM/yyyy} {valor:f2}";
  }
  // public override string ToString(){
  //   string recebeu = "Não";
  //   if (recebido) recebeu = "Sim";
  //   return $"Cliente - {cliente} \nData de Vencimento - {dataVencimento:dd/MM/yyyy} \nValor - {valor} \nRecebeu? {recebeu}";
  // }


  
}