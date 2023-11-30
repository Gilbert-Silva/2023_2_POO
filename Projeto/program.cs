using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Console.WriteLine("IF Shop");
    int op = 0;
    while (op != 99) {
      op = Menu();
      switch (op) {
        case 1: ProdutoInserir(); break;
        case 2: ProdutoListar(); break;
        case 3: ProdutoAtualizar(); break;
        case 4: ProdutoExcluir(); break;
        case 5: ProdutoSalvarCSV(); break; 
        case 6: ProdutoAbrirCSV(); break; 
      }
    }
    Console.WriteLine("Bye");
  }
  public static int Menu() {
    Console.WriteLine("Menu Produtos");
    Console.WriteLine("01 - Inserir");
    Console.WriteLine("02 - Listar");
    Console.WriteLine("03 - Atualizar");
    Console.WriteLine("04 - Excluir");
    //Console.WriteLine("05 - Salvar");
    //Console.WriteLine("06 - Abrir");
    Console.WriteLine();
    Console.WriteLine("99 - Sair");
    Console.Write("\nOpção: ");
    return int.Parse(Console.ReadLine());
  }
  public static void ProdutoInserir() {
    Console.Write("Informe o nome do produto: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o preço: ");
    double preco = double.Parse(Console.ReadLine());
    Console.Write("Informe o estoque: ");
    int estoque = int.Parse(Console.ReadLine());
    View.ProdutoInserir(nome, preco, estoque);
    Console.WriteLine("Produto cadastrado com sucesso");
  }
  public static void ProdutoListar() {
    Console.WriteLine("Cadastro de Produtos");
    foreach (Produto p in View.ProdutoListar())
      Console.WriteLine(p);
  }
  public static void ProdutoAtualizar() {

  }
  public static void ProdutoExcluir() {

  }
  public static void ProdutoSalvarCSV() {
    View.ProdutoSalvarCSV();
  }
  public static void ProdutoAbrirCSV() {
    View.ProdutoAbrirCSV();
  }
}