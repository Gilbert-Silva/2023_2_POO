using System;

namespace prova2{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite o nome do Personagem 1: ");
            string s = Console.ReadLine();
            Console.WriteLine("Digite o Valor do Ataque do Personagem 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor da Cura do Personagem 1: ");
            int c = int.Parse(Console.ReadLine());
            Personagem p1 = new Personagem(s, 1, 100, a, c);
            Console.WriteLine("Digite o nome do Personagem 2: ");
            string x = Console.ReadLine();
            Console.WriteLine("Digite o Valor do Ataque do Personagem 2: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor da Cura do Personagem 2: ");
            int z = int.Parse(Console.ReadLine());
            Personagem p2 = new Personagem(x, 1, 100, y, z);
            if(p1.Batalha(p2) == true){
                Console.WriteLine(p1.ToString());
            }
            else if(p2.Batalha(p1) == true){
                Console.WriteLine(p2.ToString());
            }
            else Console.WriteLine("Ninguem Morreu");
        }
    }
    class Personagem{
        private string nome;
        private int nivel, saude, ataque, cura;
        public Personagem(string nome, int nivel, int saude, int ataque, int cura){
            SetNome(nome);
            SetNivel(nivel);
            SetSaude(saude);
            SetAtaque(ataque);
            SetCura(cura);
        }
        public string GetNome(){
            return nome;
        }
        public int GetNivel(){
            return nivel;
        }
        public int GetSaude(){
            return saude;
        }
        public int GetAtaque(){
            return ataque;
        }
        public int GetCura(){
            return cura;
        }
        public void SetNome(string nome){
            if(nome != ""){
                this.nome = nome;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public void SetNivel(int nivel){
            if(nivel < 1){
                throw new ArgumentOutOfRangeException();
            }
            else this.nivel = nivel;
        }
        public void SetSaude(int saude){
            if(saude > 0){
                this.saude = saude;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public void SetAtaque(int ataque){
            if(ataque > 0){
                this.ataque = ataque;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public void SetCura(int cura){
            if(cura >= 0){
                this.cura = cura;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public bool Batalha(Personagem p){
            while(saude != 0){
                int vida = (saude - ataque) + cura;
                saude = vida;
            }
            if(saude == 0){
                nivel = nivel + 1;
                return true;
            }
            else return false;
        }
        public override string ToString(){
            return $"O personagem {nome} venceu a batalha e subiu para o nivel {nivel}";
        }
    }
}
