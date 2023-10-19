import java.util.Scanner;

class Programa {
    public static void main(String args[]){
        Scanner inp = new Scanner(System.in);

        System.out.println("PERSONAGEM I");
        System.out.println("Digite o nome do personagem I.");
        String nome1 = inp.next();
        System.out.println("Digite o ataque do personagem I.");
        int ataque1 = inp.nextInt();
        System.out.println("Digite a cura do personagem I.");
        int cura1 = inp.nextInt();
        Personagem p1 = new Personagem(nome1, ataque1, cura1);

        System.out.println("PERSONAGEM II");
        System.out.println("Digite o nome do personagem II.");
        String nome2 = inp.next();
        System.out.println("Digite o ataque do personagem II.");
        int ataque2 = inp.nextInt();
        System.out.println("Digite a cura do personagem II.");
        int cura2 = inp.nextInt();
        Personagem p2 = new Personagem(nome2, ataque2, cura2);

        Personagem.Batalha(p1, p2);

        System.out.println("PERSONAGENS APÓS A BATALHA");
        System.out.println(p1.toString());
        System.out.println(p2.toString());

    }
}

class Personagem {
    private String nome;
    private int nivel, saude, ataque, cura;
    //CONSTRUTOR
    public Personagem(String nome, int ataque, int cura){
        setNome(nome);
        setAtaque(ataque);
        setCura(cura);
        setNivel();
        setSaude();
    }
    //SET
    public void setNome(String nome){
        if (nome != "") this.nome = nome;
        else throw new IllegalArgumentException();
    }
    public void setNivel(){
        this.nivel = 1;
    }
    public void setSaude(){
        this.saude = 100;
    }
    public void setAtaque(int ataque){
        if (ataque >= 0 && ataque <= 100) this.ataque = ataque;
        else throw new IllegalArgumentException();
    }
    public void setCura(int cura){
        if (cura >= 0 && cura <= 100) this.cura = cura;
        else throw new IllegalArgumentException();
    }
    //GET
    public String getNome(){
        return nome;
    }
    public int getNivel(){
        return nivel;
    }
    public int getSaude(){
        return saude;
    }
    public int getAtaque(){
        return ataque;
    }
    public int getCura(){
        return cura;
    }
    //BATALHA
    public static boolean Batalha(Personagem p1, Personagem p2){
        boolean derrota = false;
        p1.saude += p1.cura;
        p2.saude += p2.cura;
        p1.saude -= p2.ataque;
        p2.saude -= p1.ataque;
        if (p1.saude <= 0){
            derrota = true; 
            p2.nivel += 1;
        }
        if (p2.saude <= 0){
            derrota = true; 
            p1.nivel += 1;
        }

        return derrota;
    }
    //TO STRING
    public String toString(){
        return "Nome: " + nome + "\n" + 
        "Nível:  " + nivel + "\n" +
        "Ataque: " + ataque + "\n" +
        "Cura: " + cura + "\n" +
        "Saúde: " + saude + "\n";
    }
}
