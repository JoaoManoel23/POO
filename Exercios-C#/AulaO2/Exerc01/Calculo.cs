using System;

namespace Exerc01{
    public class Calculo{
        int b;
        int h;

        public Calculo(int b, int h){
            this.b = b;
            this.h = h;
        }

        public int GetB(){
            return this.b;
        } 
        public int GetH(){
            return this.h;
        }
        public int GetResul(){
            return this.b*h/2;
        }


    }
}