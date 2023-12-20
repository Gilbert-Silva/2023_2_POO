using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Console.WriteLine("IF Shop");
    int op = 0;
    while (op != 99) {
      try
      {
        op = Menu();
        switch (op) {
          case 1: ProdutoInserir(); break;
          case 2: ProdutoListar(); break;
          case 3: ProdutoAtualizar(); break;
          case 4: ProdutoExcluir(); break;
          case 5: CategoriaInserir(); break; 
          case 6: CategoriaListar(); break; 
          case 7: CategoriaAtualizar(); break; 
          case 8: CategoriaExcluir(); break; 
        }
      }
      catch (Exception obj) {
        Console.WriteLine("Deu erro: " + obj.Message);
      }
    }  
    Console.WriteLine("Bye");
  }
  public static int Menu() {
    Console.WriteLine();
    Console.WriteLine("Menu Produtos");
    Console.WriteLine("01 - Inserir");
    Console.WriteLine("02 - Listar");
    Console.WriteLine("03 - Atualizar");
    Console.WriteLine("04 - Excluir");
    Console.WriteLine();
    Console.WriteLine("Menu Categoria");
    Console.WriteLine("05 - Inserir");
    Console.WriteLine("06 - Listar");
    Console.WriteLine("07 - Atualizar");
    Console.WriteLine("08 - Excluir");
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

    foreach (Categoria c in View.CategoriaListar())
      Console.WriteLine(c);
    Console.Write("\nInforme o id da categoria: ");
    int idCategoria = int.Parse(Console.ReadLine());
    
    View.ProdutoInserir(nome, preco, estoque, idCategoria);
    Console.WriteLine("Produto cadastrado com sucesso");
  }
  public static void ProdutoListar() {
    Console.WriteLine("Cadastro de Produtos");
    foreach (Produto p in View.ProdutoListar())
    {
      Categoria c = View.CategoriaListar(p.IdCategoria);
      Console.WriteLine(p + " - " + c.Nome);
    }
  }
  public static void ProdutoAtualizar() {
    ProdutoListar();
    
    Console.Write("Informe o id do produto a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe o nome do produto: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o preço: ");
    double preco = double.Parse(Console.ReadLine());
    Console.Write("Informe o estoque: ");
    int estoque = int.Parse(Console.ReadLine());

    foreach (Categoria c in View.CategoriaListar())
      Console.WriteLine(c);
    Console.Write("\nInforme o id da categoria: ");
    int idCategoria = int.Parse(Console.ReadLine());

    View.ProdutoAtualizar(id, nome, preco, estoque, idCategoria);
    Console.WriteLine("Produto cadastrado com sucesso");

  }
  public static void ProdutoExcluir() {

  }
  
  public static void CategoriaInserir() {
    Console.Write("Informe o nome da categoria: ");
    string nome = Console.ReadLine();
    View.CategoriaInserir(nome);
    Console.WriteLine("Categoria cadastrada com sucesso");
  }
  public static void CategoriaListar() {
    Console.WriteLine("Cadastro de Categorias");
    foreach (Categoria c in View.CategoriaListar())
      Console.WriteLine(c);
  }
  public static void CategoriaAtualizar() {

  }
  public static void CategoriaExcluir() {

  }
}