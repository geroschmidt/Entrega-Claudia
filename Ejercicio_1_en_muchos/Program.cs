using System;

namespace Ejercicio_1_en_muchos
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Persona persona1 = new Persona("Geronimo");

                Persona persona2 = new Persona("Juan");

                Persona persona3 = new Persona("Jose");

                Departamento dpto1 = new Departamento();

                dpto1.AddEmployee(persona1);

                dpto1.AddEmployee(persona2);

                dpto1.AddEmployee(persona3);

                foreach (Persona o in dpto1.Employees)
                {
                    Console.WriteLine("Empleado: " + o.nombre);
                }

                Console.WriteLine("La cantidad de persona es: " + dpto1.Employees.Count);
            }

        }
    }

