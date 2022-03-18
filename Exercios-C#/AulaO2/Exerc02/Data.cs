using System;

namespace Exerc02{
     public class Data{
         int dia;
         int mes;
         int ano;

         public Data(int dia, int mes, int ano){
             this.dia = dia;
             this.mes = mes;
             this.ano = ano;
         }

         public int GetDia(){
             return this.dia;
         }
         public int GetMes(){
             return this.mes;
         }
         public int GetAno(){
             return this.ano;
         }
         
         
         public void VerificarData(){
             if((mes == 02) && (dia > 28)){ 
                 Console.WriteLine("Data inválida");
                 Console.WriteLine("Dia:"+dia);
                 Console.WriteLine("Mês:"+mes);
             }
             if((mes>12) || (mes <= 0)){
                 Console.WriteLine("Mês inválido");
             }
             if((dia > 30) && ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))){
                 Console.WriteLine("Data inválida");
                 Console.WriteLine("Este mês não tem 31 dias");
             }
             if((dia > 31) || (dia <= 0)){
                 Console.WriteLine("Dia inválido");
             }
             if(ano <= 0){
                 Console.WriteLine("Ano inválido");
             }
             else{
                 Console.WriteLine("Data: "+dia+"/"+mes+"/"+ano);
             }
             
         }

     }
}