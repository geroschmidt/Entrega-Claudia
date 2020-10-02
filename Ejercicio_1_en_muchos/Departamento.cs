using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ejercicio_1_en_muchos
{
    class Departamento
    {
        private ArrayList employees = new ArrayList();


        public ArrayList Employees
        {
            get
            {
                return employees;
            }

            set
            {

                this.employees = value;
            }
        }


        public void AddEmployee(Persona employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Persona employee)
        {
            employees.Remove(employee);
        }


        public int GetEmployeeCount()
        {
            return employees.Count;
        }

    }

}

