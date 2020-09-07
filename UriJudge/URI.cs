using System;
using UriJudge._1018;

namespace UriJudge
{
    class URI
    {
        static void Main(string[] args)
        {
            String valorUsuario = Console.ReadLine();
            int valor = Convert.ToInt32(valorUsuario);
            
            var cedulas = new Cedula();
            cedulas.Run(valor);
        }
    }
}
