public class ex03 {
  public static void main(String[] args) {
    Estacao x = Estacao.Outono;
    System.out.println(x);
    if (x == Estacao.Outono)
      System.out.println("Teste");
    // Pesquisar EnumSet
    Dias poo = Dias.Quarta;
    System.out.println(poo);
  }
}

public enum Estacao{
  Primavera(1), Verao(2), Outono(3), Inverno(4);
  public final int valor;
  Estacao(int id){
    this.valor = id;
   }
  //public int getValor(){
  //  return valor;
  //}
}
public enum Dias {
  Nenhum(0), Segunda(1), Terca(2), Quarta(4), Quinta(8), Sexta(16), Sabado(32), Domingo(64);
  public final int valor;
  Dias(int id){
    this.valor = id;
  }
}

