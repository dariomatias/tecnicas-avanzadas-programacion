using System;
using System.Diagnostics.CodeAnalysis;

namespace Negocio
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private int Dni { get; set; }
        private string Sexo { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }

        private const string HOMBRE = "H";
        private const string MUJER = "M";

        public Persona() { }

        public Persona(int dni, string nombre, int edad, string sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Sexo = sexo;
            Altura = 0;
            Peso = 0;
        }

        public Persona(int dni, string nombre = "", int edad = 0, string sexo = HOMBRE, double altura = 0, double peso = 0)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Sexo = sexo;
            Altura = altura;
            Peso = peso;
        }

        public bool Validar()
        {
            return (!string.IsNullOrEmpty(Nombre)
                    && !string.IsNullOrEmpty(Sexo)
                    && Dni != 0
                    && Edad != 0
                    && Altura != 0
                    && Peso != 0);
        }

        public void Modificar(int dni, string nombre, int edad, string sexo, double altura, double peso)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Sexo = sexo;
            Altura = altura;
            Peso = peso;
        }

        public Persona Agregar(int dni, string nombre, int edad, string sexo, double altura, double peso)
        {
            Persona p = new Persona(dni, nombre, edad, sexo, altura, peso);
            return p;
        }

    }
}
