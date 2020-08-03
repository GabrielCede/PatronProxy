using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ProxyProyecto.clase;

namespace ProxyProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Proceso con el Proxy Sencillo el cuál no pide acceso
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();

            miProxy.Peticion(1);
            Console.WriteLine("--------");
            miProxy.Peticion(2);
            Console.WriteLine("--------");

            //Proceso con el Proxy Seguro el cuál pide acceso
            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();

            miProxyS.Peticion(1);
            Console.WriteLine("--------");
            miProxyS.Peticion(2);
            Console.WriteLine("--------");
        }
    }
}
