using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFunciones
{
    public class ClaFunciones
    {
        /// <summary>
        /// Esta funcion calcula si el numero es par o impar
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string EsPar(int num)
        {
            if (num % 2 == 0)
                return "Par";
            else
                return "Impar";
        }
        /// <summary>
        /// Calcular el nombre del mes ingresando un numero
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public string nombreMes(int mes)
        {

            if (mes == 1)
                return "Enero";
            if (mes == 2)
                return "Febrero";
            if (mes == 3)
                return "Marzo";
            if (mes == 4)
                return "Abril";
            if (mes == 5)
                return "Mayo";
            if (mes == 6)
                return "Junio";
            if (mes == 7)
                return "Julio";
            if (mes == 8)
                return "Agosto";
            if (mes == 9)
                return "Septiembre";
            if (mes == 10)
                return "Octubre";
            if (mes == 11)
                return "Noviembre";
            if (mes == 12)
                return "Diciembre";
            else
                return "Numero no valido ....!!";
        }
    }
}
