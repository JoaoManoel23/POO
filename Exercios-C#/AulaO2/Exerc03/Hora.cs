using System;

namespace Exerc03{
    public class Hora{
        int hora;
        int minuto;
        int segundo;

        public  Hora(int hora, int minuto, int segundo){
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }

        public int GetHora(){
            return this.hora;
        }
        public int GetMinuto(){
            return this.minuto;
        }
        public int GetSegundo(){
            return this.segundo;
        }

        public void VerificarHora(){
            if((hora < 0) || (hora > 23)){
                Console.WriteLine("Horário inválido");
            }
            if((minuto > 59) || (minuto < 0)){
                Console.WriteLine("Minuto inválido");
            }
            if((segundo > 59) || (segundo < 0)){
                Console.WriteLine("Segundo inválido");
            }
            else{
                Console.WriteLine("Horário:"+hora+":"+minuto+':'+segundo);
            }
        }
    }
}