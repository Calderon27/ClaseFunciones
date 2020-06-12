using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseFunciones.ClaFunciones op = new ClaseFunciones.ClaFunciones();
            Console.WriteLine("Por favor ingresar un numero entero");
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);
            string resultado = op.EsPar(x);
            Console.WriteLine("El numero <{0}> es {1}", x, resultado);
            Console.ReadKey();

            ClaseFunciones.ClaFunciones opc = new ClaseFunciones.ClaFunciones();
            Console.WriteLine("Por favor ingresar un mes en numeros");
            string mes = Console.ReadLine();
            int y = Convert.ToInt32(mes);
            string resultado1 = opc.nombreMes(y);
            Console.WriteLine("El numero <{0}> representa al mes es: {1}", y, resultado1);
            Console.ReadKey();
        }
    }
}
