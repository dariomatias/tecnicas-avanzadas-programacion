using System;
using Negocio;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaVacia = new Persona();
            Persona personaMinimosDatos = new Persona(11222333, "Juan", 30);
            Persona personaDatosCompletos = new Persona(22333444, "Carlos", 28, "H", 1.70, 72.200);


        }
    }
}
