using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyProyecto.clase
{
    public class CProxy
    {
        //Haremos uso de anidamiento dentro de la clase 
        //Esto hace que cualquier clase colocada como privada y anidada,solo sea conocida por Cproxy


        //Creamos nuestra interface que tiene solo un metodo que no retorna nada y recibe como parametro un entero (pOpcion).
        //Aunque la interface esté anidada tiene acceso público
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }
        //Esta clase nos va a servir como intermediario entre nuestro cliente y la clase CCocina que es el sujeto con el cuál queremos interactuar 
        //y esta clase hereda de la interface ISujeto
        public class ProxySencillo:ISujeto
        {
            private CCocina cocina;

            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el Sujeto");
                    cocina = new CCocina();
                }
                if (pOpcion == 1)
                    cocina.RecetaSecreta();
                if (pOpcion == 2)
                    cocina.Cocinar(5);

            }

        }
        public class ProxySeguro : ISujeto
        {
            private CCocina cocina;
            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine("Ingrese el Password:");
                password = Console.ReadLine();

                if (password=="abc123")
                {
                    if (cocina==null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new CCocina();
                    }
                    if (pOpcion == 1)
                        cocina.RecetaSecreta();
                    if (pOpcion == 2)
                        cocina.Cocinar(5);
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }


        //Esta es la clase que estamos protegiendo con el Proxy
        private class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de Oliva ");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamón");
                Console.WriteLine("Queso");

            }
            public void  Cocinar (int n)
            {
                Console.WriteLine("Cocinando {0} recetas ",n);
            }
        }
    }
}
