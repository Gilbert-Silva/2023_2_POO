using System;
using System.Collections.Generic;

static class View {
  public static void ProdutoInserir(string nome, double preco, int estoque, int idCategoria) {
    if (preco < 0) throw new ArgumentOutOfRangeException("Preço inválido");
    if (estoque < 0) throw new ArgumentOutOfRangeException("Estoque inválido");
    Produto p = new Produto{ Nome = nome, Preco = preco, Estoque = estoque, IdCategoria = idCategoria }; 
    NProduto np = new NProduto();
    np.Inserir(p);
  }
  public static List<Produto> ProdutoListar() {
    NProduto np = new NProduto();
    return np.Listar();
  }
  public static List<Produto> ProdutoListar(int idCategoria) {
    NProduto np = new NProduto();
    return np.Listar(new Categoria { Id = idCategoria });
  }
  public static void ProdutoAtualizar(int id, string nome, double preco, int estoque, int idCategoria) {
    if (preco < 0) throw new ArgumentOutOfRangeException("Preço inválido");
    if (estoque < 0) throw new ArgumentOutOfRangeException("Estoque inválido");
    Produto p = new Produto{ Nome = nome, Preco = preco, Estoque = estoque, IdCategoria = idCategoria }; 
    NProduto np = new NProduto();
    np.Atualizar(p);
  }
  public static void ProdutoExcluir(int id) {
    Produto p = new Produto{ Id = id };
    NProduto np = new NProduto();
    np.Excluir(p);
  }

  public static void CategoriaInserir(string nome) {
    Categoria c = new Categoria{ Nome = nome }; // Objeto da entidade
    NCategoria nc = new NCategoria();           // Objeto da persistência
    nc.Inserir(c);
  }
  public static List<Categoria> CategoriaListar() {
    NCategoria nc = new NCategoria();
    return nc.Listar();
  }
  public static Categoria CategoriaListar(int id) {
    NCategoria nc = new NCategoria();
    return nc.Listar(id);
  }
  public static void CategoriaAtualizar(int id, string nome) {
    Categoria c = new Categoria{ Id = id, Nome = nome };
    NCategoria nc = new NCategoria();
    nc.Atualizar(c);
  }
  public static void CategoriaExcluir(int id) {
    Categoria c = new Categoria{ Id = id };
    NCategoria nc = new NCategoria();
    nc.Excluir(c);
  }



}