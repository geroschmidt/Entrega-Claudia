using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1_en_muchos
{
    class Persona
    {
        public String nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
        public Persona(String Nombre)
        {
            this.nombre = Nombre;
        }

    }
}
