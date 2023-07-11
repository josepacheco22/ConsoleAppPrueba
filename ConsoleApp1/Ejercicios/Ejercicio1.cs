using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ejercicios
{
    public class Ejercicio1
    {
        public int CantidadDineroAhorrar;
        public DateTime FechaInicioAhorro;
        public double TasaAhorro;
        public int CantidadPeriodosAhorrar;

        public DateTime FechaFinAhorro;
        public double CantidadInteres;

        public Ejercicio1(){}
        public void llenardatos()
        {
            this.CantidadDineroAhorrar = 60000;
            this.FechaInicioAhorro = DateTime.Today;
            this.TasaAhorro = 2.00;
            this.CantidadPeriodosAhorrar=4;

            this.CantidadInteres = (4*30)*(this.CantidadDineroAhorrar * this.TasaAhorro)/36000;
            this.FechaFinAhorro = FechaInicioAhorro.AddMonths(CantidadPeriodosAhorrar);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Informacion Ingresada:");
            Console.WriteLine("Cantidad de Dinero a Ahorrar: " + CantidadDineroAhorrar);
            Console.WriteLine("Fecha Inicio Ahorro: " + FechaInicioAhorro);
            Console.Write("Tasa de Ahorro: ");
            Console.WriteLine("{0:N2}",TasaAhorro);
            Console.WriteLine("Periodos a Ahorrar: " + CantidadPeriodosAhorrar + " (" + (30 * CantidadPeriodosAhorrar)+" Dias)");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Calculo Final:");
            Console.WriteLine("Fecha fin de Ahorro : " + FechaFinAhorro);
            Console.Write("Cantidad : ");
            Console.WriteLine("{0:N6}", CantidadInteres);
            Console.WriteLine("");
            //Console.WriteLine(CantidadDineroAhorrar);

        }
    }
}
