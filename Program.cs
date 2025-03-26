// See https://aka.ms/new-console-template for more information
using System;

class Program{
    class Calculatrice {
        public double num1, num2;
        public double nombre1 (){
            Console.WriteLine("Entrez un nombre :");
            num1 = Convert.ToDouble(Console.ReadLine ());
            return num1;
        }
        public double nombre2 (){
            Console.WriteLine("Entrez un deuxième nombre :");
            num2 = Convert.ToDouble(Console.ReadLine ());
            return num2;
        }
        public double Somme (double numbr1, double numbr2){
            return numbr1 + numbr2;
        }
        public double Multiplication (double numbr1, double numbr2){
            return numbr1 * numbr2;
        }
        public double Divide (double numbr1, double numbr2){
            if(numbr2 == 0){
                Console.WriteLine("Impossible de Faire la division");
            }                
            return numbr1 / numbr2;
        }
        public double soustract (double numbr1, double numbr2){
            return numbr1 - numbr2;
        }
    }
    public static void Main(){
        Calculatrice calcul = new Calculatrice();
        double first = calcul.nombre1();
        double second = calcul.nombre2();
        Console.WriteLine("Multiplication : "+calcul.Multiplication(first, second));
        Console.WriteLine("Division : "+calcul.Divide(first, second));
        Console.WriteLine("Soustraction : "+calcul.soustract(first, second));
        Console.WriteLine("Addition : "+calcul.Somme(first, second));
    }
}
