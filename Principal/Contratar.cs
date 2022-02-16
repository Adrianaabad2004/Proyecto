using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    class Contratar
    {
        public Contratar()
        {
        }

        public void Contratar_Empleado(List<Empleado> list)
        {
            Empleado e = new Empleado();

            Console.Write("Cedula: ");
            e.cedula = Console.ReadLine();
            Console.Write("Nombre: ");
            e.nombre = Console.ReadLine();
            Console.Write("Departamento: ");
            e.departamento = Console.ReadLine();
            Console.Write("Cargo: ");
            e.cargo = Console.ReadLine();
            Console.Write("Salario: ");
            e.salario = double.Parse(Console.ReadLine());

            list.Add(e);
        }
    }
}
