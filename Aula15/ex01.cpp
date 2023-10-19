#include <bits/stdc++.h>
using namespace std;

class Corrida{
    private:
        string Data;
        string HoraInicio;
        string Duracao;
        double Distancia;
        int hora, minuto, segundo;
    public:
        double getdistancia(){return Distancia;}
        string getdata(){return Data;}
        string gethorainicio(){return HoraInicio;}
        string getDuracao(){return Duracao;}

        Corrida(){}
        Corrida(string Data, string HoraInicio, string Duracao, double Distancia){
            this->setdata(Data);
            this->sethorainicio(HoraInicio);
            this->setduracao(Duracao);
            this->setdistancia(Distancia);
        }

        void setdata(string valor){
            Data = valor;
        }
        void sethorainicio(string HoraInicio){
          string horastr = HoraInicio.substr(0, 2);
          string minutostr = HoraInicio.substr(3, 2);
          int hora = stoi(horastr);
          int minuto = stoi(minutostr);
          if(hora < 0 || hora > 23){
            throw invalid_argument("Valor inválido");
          }
          if(minuto < 0 || minuto > 59){
            throw invalid_argument("Valor inválido");
          }
          this->HoraInicio = HoraInicio;
        }

        void setduracao(string Duracao){
          string horastr = Duracao.substr(0, 2);
          string minutostr = Duracao.substr(3, 2);
          string segundostr = Duracao.substr(6, 2);
          hora = stoi(horastr);
          minuto = stoi(minutostr);
          segundo = stoi(segundostr);
          if(hora < 0 || hora > 23){
            throw invalid_argument("Valor inválido");
          }
          if(minuto < 0 || minuto > 59){
            throw invalid_argument("Valor inválido");
          }
          if(segundo < 0 || segundo > 59){
            throw invalid_argument("Valor inválido");
          }
          this->Duracao = Duracao;
        }
        void setdistancia(double Distancia){
            if(Distancia>0){ this->Distancia = Distancia;}
        }
        double calcvm(){
          return (Distancia/1000)/(hora + minuto/60.0 + segundo/3600.0);
        }
        string ToStr(){
          return "Data: " + Data + " Hora Inicio: " + HoraInicio +
            " Duracao: " + Duracao + " Distancia: " + to_string(Distancia);
        }
};

int main(){
    Corrida corredor = Corrida("12/08/2005", "12:58", "02:00:00", 42000);
    cout << corredor.calcvm() << " km/h\n";
    cout << corredor.ToStr() << endl;
}