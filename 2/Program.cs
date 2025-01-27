using System;
using _2.clases;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {






            Gladiador gladiador1 = new Gladiador();
            gladiador1.darnombre("peleador 1");

            Gladiador gladiador2 = new Gladiador();
            gladiador2.darnombre("peleador 2");

            Console.WriteLine($"en un lado tenemos a {gladiador1.mostrarnombre()}");
            Console.WriteLine($"con una fuerza de {gladiador1.mostrarfuerza()}");
            Console.WriteLine($"y una velocidad de  {gladiador1.mostrarvelocidad()}");
            Console.WriteLine($"y una suerte  de  {gladiador1.mostrarsuerte()}");
            Console.Write($"portando una amrmadura");
            switch (gladiador1.mostrararmadura())
            {
                case 1:
                    Console.WriteLine(" mala");
                    break;
                case 2:
                    Console.WriteLine(" mala");
                    break;
                case 3:
                    Console.WriteLine(" buena");
                    break;


            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"y al otro  lado tenemos a {gladiador2.mostrarnombre()}");
            Console.WriteLine($"con una fuerza de  {gladiador2.mostrarfuerza()}");
            Console.WriteLine($"y una velocidad de  {gladiador2.mostrarvelocidad()}");
            Console.WriteLine($"y una suerte  de  {gladiador2.mostrarsuerte()}");
            Console.Write($"portando una amrmadura");
            switch (gladiador2.mostrararmadura())
            {
                case 1:
                    Console.WriteLine(" mala");
                    break;
                case 2:
                    Console.WriteLine(" media");
                    break;
                case 3:
                    Console.WriteLine(" buena");
                    break;


            }
            Console.WriteLine("---------------------------------------------------");
            System.Threading.Thread.Sleep(1000);
            int pmayor = 0;
            int pmenor = 0;
            bool gla1;
            bool gla2;
            if (gladiador1.mostrarvelocidad()>gladiador2.mostrarvelocidad())
            {
                pmayor = (gladiador2.mostrarvelocidad() * 100 )/ gladiador1.mostrarvelocidad();
                pmenor = 100-pmayor;
                gla1 = true;
                gla2 = false;


            }
            else
            {
                pmayor = (gladiador1.mostrarvelocidad() * 100) / gladiador2.mostrarvelocidad();
                pmenor = 100-pmayor;

                gla2 = true;
                gla1 = false;

            }
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                var randomNumber = new Random().Next(1,3);
                //turno del gradiador 1
                if (randomNumber==1)
                {
                    Console.WriteLine($"{gladiador1.mostrarnombre()} intenta atacar");
                    //comprobar si su velocidad es mayor
                    if (gla1==true)
                    {
                        var velocidadataque = new Random().Next(1, 101);
                        //si el ataque atino
                        if (velocidadataque<=pmayor)
                        {
                            Console.WriteLine($" logra atacar ");

                            gladiador2.resivirdaño(gladiador1.atacar());
                            Console.WriteLine($"vida restante de {gladiador2.mostrarnombre()} es de {gladiador2.mostrarvida()}");
                            Console.WriteLine($"---------------------------------------");
                            //comprobar si la vida del oponente esta por debajo de 0
                            if (gladiador2.mostrarvida() <= 0)
                            {
                                
                                Console.WriteLine("combate terminado");
                                Console.WriteLine($"el ganador es {gladiador1.mostrarnombre()}");
                                break;
                            }

                        }
                        //el ataque no dio
                        else
                        {
                            Console.WriteLine($"{gladiador2.mostrarnombre()} ha logrado esquivar el ataque");
                            Console.WriteLine($"---------------------------------------");
                        }


                    }
                    //su velocidad es menor 
                    else
                    {
                        var velocidadataque = new Random().Next(1, 101);
                        //si el ataque atino
                        if (velocidadataque <= pmenor)
                        {
                            Console.WriteLine($" logra atacar ");

                            gladiador2.resivirdaño(gladiador1.atacar());
                            Console.WriteLine($"vida restante de {gladiador2.mostrarnombre()} es de {gladiador2.mostrarvida()}");
                            Console.WriteLine($"---------------------------------------");
                            //comprobar si la vida del oponente esta por debajo de 0
                            if (gladiador2.mostrarvida() <= 0)
                            {

                                Console.WriteLine("combate terminado");
                                Console.WriteLine($"el ganador es {gladiador1.mostrarnombre()}");
                                break;
                            }

                        }
                        //el ataque no dio
                        else
                        {
                            Console.WriteLine($"{gladiador2.mostrarnombre()} ha logrado esquivar el ataque");
                            Console.WriteLine($"---------------------------------------");
                        }

                    }


                }
                //turno del gladiador 2
                else
                {
                    Console.WriteLine($"{gladiador2.mostrarnombre()} intenta atacar");
                    //comprobar si su velocidad es mayor
                    if (gla2 == true)
                    {
                        var velocidadataque = new Random().Next(1, 3);
                        //si el ataque atino
                        if (velocidadataque <= pmayor)
                        {
                            Console.WriteLine($" logra atacar ");

                            gladiador1.resivirdaño(gladiador2.atacar());
                            Console.WriteLine($"vida restante de {gladiador1.mostrarnombre()} es de {gladiador1.mostrarvida()}");
                            Console.WriteLine($"---------------------------------------");
                            //comprobar si la vida del oponente esta por debajo de 0
                            if (gladiador1.mostrarvida() <= 0)
                            {

                                Console.WriteLine("combate terminado");
                                Console.WriteLine($"el ganador es {gladiador2.mostrarnombre()}");
                                break;
                            }

                        }
                        //el ataque no dio
                        else
                        {
                            Console.WriteLine($"{gladiador1.mostrarnombre()} ha logrado esquivar el ataque");
                            Console.WriteLine($"---------------------------------------");

                        }

                    }
                    //su velocidad es menor 
                    else
                    {
                        var velocidadataque = new Random().Next(1, 101);
                        //si el ataque atino
                        if (velocidadataque <= pmenor)
                        {
                            Console.WriteLine($" logra atacar ");

                            gladiador1.resivirdaño(gladiador2.atacar());
                            Console.WriteLine($"vida restante de {gladiador1.mostrarnombre()} es de {gladiador1.mostrarvida()}");
                            Console.WriteLine($"---------------------------------------");
                            //comprobar si la vida del oponente esta por debajo de 0
                            if (gladiador1.mostrarvida() <= 0)
                            {

                                Console.WriteLine("combate terminado");
                                Console.WriteLine($"el ganador es {gladiador2.mostrarnombre()}");
                                break;

                            }

                        }
                        //el ataque no dio
                        else
                        {
                            Console.WriteLine($"{gladiador1.mostrarnombre()} ha logrado esquivar el ataque");
                            Console.WriteLine($"---------------------------------------");

                        }

                    }

                }



            }

             












        }
    }
}
