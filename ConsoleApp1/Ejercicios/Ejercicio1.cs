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
        public double CantidadDineroAhorrar;
        public DateTime FechaInicioAhorro;
        public double TasaAhorro;
        public int CantidadPeriodosAhorrar;
        public double SaldoActual;

        public DateTime FechaFinAhorro;
        public double CantidadInteres;

        public Ejercicio1(){
            llenardatos();
            Console.Clear();
            CalculoFinal();
            Regresar();
        }
        public void llenardatos()
        {

            var SalidaIngresoValores = true;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese Saldo Actual: ");
                Console.WriteLine("");
                try
                {
                    SaldoActual = double.Parse(Console.ReadLine());
                    if (SaldoActual > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }

            SalidaIngresoValores = true;
            
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese cantidad de dinero Ahorrar: ");
                Console.WriteLine("");
                try
                {
                    CantidadDineroAhorrar = double.Parse(Console.ReadLine());
                    if (CantidadDineroAhorrar > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }

            SalidaIngresoValores = true;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese tasa de ahorro: ");
                Console.WriteLine("");
                try
                {
                    TasaAhorro = double.Parse(Console.ReadLine());
                    if (TasaAhorro > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }

            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese tasa de ahorro: ");
                Console.WriteLine("");
                try
                {
                    TasaAhorro = double.Parse(Console.ReadLine());
                    if (TasaAhorro > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }

            SalidaIngresoValores = true;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese cantidad de Periodos a Ahorrar ( 1 periodo = 30 dias): ");
                Console.WriteLine("");
                try
                {
                    CantidadPeriodosAhorrar = int.Parse(Console.ReadLine());
                    if (CantidadPeriodosAhorrar > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }
            FechaInicioAhorro = DateTime.Today;

            var DiasCantidadPeriodosAhorrar = (CantidadPeriodosAhorrar * 30);
            var SaldoCuenta = SaldoActual;
            var Interes = 0.0;
            while (DiasCantidadPeriodosAhorrar > 0)
            {
                Interes = Math.Round(((SaldoCuenta * TasaAhorro) / 36000), 6);
                SaldoCuenta += Interes;
                CantidadInteres += Interes;
                DiasCantidadPeriodosAhorrar--;
            }
            FechaFinAhorro = FechaInicioAhorro.AddMonths(CantidadPeriodosAhorrar);
        }
        public void CalculoFinal()
        {
            Console.WriteLine("Informacion Ingresada:");
            Console.WriteLine(""); 
            Console.WriteLine("Saldo Actual en la cuenta: " + SaldoActual);
            Console.WriteLine("Cantidad de Dinero a Ahorrar: " + CantidadDineroAhorrar);
            Console.WriteLine("Fecha Inicio Ahorro: " + FechaInicioAhorro.ToString("dd/MM/yyyy"));
            Console.Write("Tasa de Ahorro: ");
            Console.WriteLine("{0:N2}", TasaAhorro);
            Console.WriteLine("Periodos Ahorrar: " + CantidadPeriodosAhorrar + " (" + (30 * CantidadPeriodosAhorrar) + " Dias)");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Calculo Final:");
            Console.WriteLine("");
            Console.WriteLine("Fecha fin de Ahorro : " + FechaFinAhorro.ToString("dd/MM/yyyy"));
            Console.Write("Cantidad : ");
            Console.WriteLine("{0:N6}", CantidadInteres);
            Console.WriteLine("");
        }
        public void Regresar()
        {
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para regresar.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
