using System;
using System.Collections.Generic;

static class View {
  public static void ProdutoInserir(string nome, double preco, int estoque) {
    Produto p = new Produto{ Nome = nome, Preco = preco, Estoque = estoque };
    NProduto.Inserir(p);
  }
  public static List<Produto> ProdutoListar() {
    return NProduto.Listar();
  }
  public static void ProdutoAtualizar(int id, string nome, double preco, int estoque) {
    Produto p = new Produto{ Id = id, Nome = nome, Preco = preco, Estoque = estoque };
    NProduto.Atualizar(p);
  }
  public static void ProdutoExcluir(int id) {
    Produto p = new Produto{ Id = id };
    NProduto.Excluir(p);
  }
  public static void ProdutoSalvarCSV() {
    NProduto.ToXML();
  }
  public static void ProdutoAbrirCSV() {
    NProduto.FromXML();
  }
}