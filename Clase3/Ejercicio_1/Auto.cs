using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Auto
    {
        public eFabricante fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        public static int ContadorDeObjetos;
        public int KilometrosRecorridos;
        private static int numerorandom;
        private static Random rng;
        public Auto Maximo;
        public Auto Minimo;
       

        public Auto()
        {
            
            switch (numerorandom)
            {
                case 1:                    
                    this.fabricante = (eFabricante)1;
                    break;
                case 2:
                    this.fabricante = (eFabricante)2;
                    break;
                case 3:
                    this.fabricante = (eFabricante)3;
                    break;
            }            
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TD = new Rueda();
            this.TI = new Rueda();
            Auto.ContadorDeObjetos++;
        }
        public int MinyMax()
        {
            return this.KilometrosRecorridos;
        }

        public void VolverCero()
        {
            KilometrosRecorridos = 0;
        }

        public void AgregarKilometros(int kilometros)
        {
            KilometrosRecorridos = kilometros;
            
        }

        

        public void MostrarAuto()
        {
            Console.WriteLine("El fabricante es: " + fabricante);
            Console.WriteLine("Los kilometros recorridos: " + KilometrosRecorridos);
            
        }
         
        static Auto()//No lleva modificador de visibilidad si es estatico
        {
            rng = new Random();
            numerorandom = rng.Next(1, 3);
        
            Auto.ContadorDeObjetos = 0;
            

        }

        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1.fabricante == auto2.fabricante)
            {
                return true;
            }
            else
            {
                return false;

                   
            }
        }

        

    }
}
