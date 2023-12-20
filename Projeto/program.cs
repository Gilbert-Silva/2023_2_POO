using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Console.WriteLine("IF Shop");
    if (Login() == "admin") {
      int op = 0;
      while (op != 99) {
        try
        {
          op = MenuAdmin();
          switch (op) {
          case 1: ProdutoInserir(); break;
          case 2: ProdutoListar(); break;
          case 3: ProdutoListarCategoria(); break;
          case 4: ProdutoAtualizar(); break;
          case 5: ProdutoExcluir(); break;
          case 6: CategoriaInserir(); break; 
          case 7: CategoriaListar(); break; 
          case 8: CategoriaAtualizar(); break; 
          case 9: CategoriaExcluir(); break; 
          }
        }
        catch (Exception obj) {
          Console.WriteLine("Deu erro: " + obj.Message);
        }
      }  
      Console.WriteLine("Bye");
    }
    else {
      int op = 0;
      while (op != 99) {
        try
        {
          op = MenuUsuario();
          switch (op) {
          case 1: ProdutoListar(); break;
          case 2: ProdutoListarCategoria(); break;
          case 3: CategoriaListar(); break; 
          }
        }
        catch (Exception obj) {
          Console.WriteLine("Deu erro: " + obj.Message);
        }
      }  
      Console.WriteLine("Bye");
    }
  }
  public static string Login() {
    Console.WriteLine();
    Console.Write("E-mail: ");
    string email = Console.ReadLine();
    Console.Write("Senha: ");
    string senha = Console.ReadLine();
    if (email == "admin" && senha == "123456") {
      return "admin";
    }
    return "usuario";
  }
  
  public static int MenuUsuario() {
    Console.WriteLine();
    Console.WriteLine("Menu Produtos");
    Console.WriteLine("01 - Listar");
    Console.WriteLine("02 - Listar por Categoria");
    Console.WriteLine();
    Console.WriteLine("Menu Categoria");
    Console.WriteLine("03 - Listar");
    Console.WriteLine();
    Console.WriteLine("99 - Sair");
    Console.Write("\nOpção: ");
    return int.Parse(Console.ReadLine());
  }
  
  public static int MenuAdmin() {
    Console.WriteLine();
    Console.WriteLine("Menu Produtos");
    Console.WriteLine("01 - Inserir");
    Console.WriteLine("02 - Listar");
    Console.WriteLine("03 - Listar por Categoria");
    Console.WriteLine("04 - Atualizar");
    Console.WriteLine("05 - Excluir");
    Console.WriteLine();
    Console.WriteLine("Menu Categoria");
    Console.WriteLine("06 - Inserir");
    Console.WriteLine("07 - Listar");
    Console.WriteLine("08 - Atualizar");
    Console.WriteLine("09 - Excluir");
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
  public static void ProdutoListarCategoria() {
    Console.WriteLine("Cadastro de Produtos por Categoria");
    foreach (Categoria c in View.CategoriaListar())
      Console.WriteLine(c);
    Console.Write("\nInforme o id da categoria: ");
    int idCategoria = int.Parse(Console.ReadLine());
    foreach (Produto p in View.ProdutoListar(idCategoria))
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