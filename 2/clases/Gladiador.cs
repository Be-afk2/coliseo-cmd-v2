using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.clases
{
    class Gladiador
    {
        private int vida;
        private int fuerza;
        private int velocidad;
        private string nombre;
        private int suerte;
        private int armadura;

        public Gladiador()
        {
            vida = 100;
            var randomNumber = new Random().Next(1, 11);
            fuerza = randomNumber;
            var randomNumber1 = new Random().Next(1, 11);
            this.velocidad = randomNumber1;
            var randomNumber2 = new Random().Next(1, 10);
            this.suerte = randomNumber2;
            var randomNumber3 = new Random().Next(1, 4);
            this.armadura = randomNumber3;
         

        }
        //armadura-----------------------------------------------------
        public int mostrararmadura()
        {

            return this.armadura;
        }
        //suerte--------------------------------------------------------
        public int mostrarsuerte()
        {
            return this.suerte;
        }
        //vida----------------------------------------------------------

        public int mostrarvida()
        {


            return this.vida;
        }
        //fuerza--------------------------------------------------------
        public  int mostrarfuerza()
        {

            return this.fuerza;
        }
        //velocidad-------------------------------------------------------
        public int mostrarvelocidad()
        {
            return this.velocidad;
        }
        //nombre-----------------------------------
        public void darnombre(string valordado)
        {
            this.nombre = valordado;
        }
        public string mostrarnombre()
        {
            return this.nombre;
        }
        //funciones--------------------------------

        public int atacar()
        {
            int dañoreal = 0;
            var daño = new Random().Next(1, 10);
            var suerte = new Random().Next(1, 10);
            if (this.suerte<=suerte)
            {
                Console.WriteLine("ataque critico");
                dañoreal = this.fuerza * daño;
                dañoreal= dañoreal * 2;
                return dañoreal;
            }
            else
            {
                dañoreal = this.fuerza * daño; 
                return dañoreal;
            }
            

            
        }
        public void resivirdaño(int valordado)
        {
            int dañoreal;
            int daño;
            switch (armadura)
            {

                case 1:
                    daño = (valordado*3)/100;
                    dañoreal = valordado - daño;
                    this.vida = this.vida-dañoreal;
                    break;
                case 3:
                    daño = (valordado * 5) / 100;
                    dañoreal = valordado - daño;
                    this.vida = this.vida - dañoreal;
                    break;
                case 2:
                    daño = (valordado * 10) / 100;
                    dañoreal = valordado - daño;
                    this.vida = this.vida - dañoreal;
                    break;

            }

        }
    }
}
