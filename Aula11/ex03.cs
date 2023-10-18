using System;

class Program {
  public static void Main() {
    string s = new string("C#");
    Console.WriteLine(s);
    Lista x = new Lista();
    x.Inserir("Programação");
    x.Inserir("Orientada");
    x.Inserir("a Objetos");
    x.InserirNoInicio("Disciplina");
    Console.WriteLine(x.Listar());
  }
}

class Lista {
  private No inicio = null, fim = null;
  public void InserirNoInicio(string valor) {
    No novo = new No();
    novo.valor = valor;
    if (inicio == null) {
      inicio = novo;
      fim = novo;
    }
    else {
      novo.prox = inicio;
      inicio = novo;
    }
  }
  public void Inserir(string valor) {
    No novo = new No();
    novo.valor = valor;
    if (inicio == null) {
      inicio = novo;
      fim = novo;
    }
    else {
      fim.prox = novo;
      fim = novo;
    }
  }
  public string Listar() {
    string r = "[";
    No aux = inicio;
    while (aux != null) {
      r += aux.valor + ", ";
      aux = aux.prox;
    }
    r += "]";
    return r;
  }
}

class No {
  public string valor;
  public No prox;
}