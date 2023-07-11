using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ejercicios
{
    public class Ejercicio2
    {
        public List<string> CodigoDivisa = new List<string>();
        public List<double> ValorDivisa = new List<double>();
        public Ejercicio2() {
            var Salir = true;
            CodigoDivisa.Add("USD");
            ValorDivisa.Add(1.0);
            while (Salir)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Ingresar Nueva Divisa");
                    Console.WriteLine("2. Editar Divisa");
                    Console.WriteLine("3. Mostrar Divisas");
                    Console.WriteLine("4. Convertir");
                    Console.WriteLine("5. Salir");
                    var OpcionSeleccionada = Console.ReadLine();
                    Console.Clear();
                    switch (int.Parse(OpcionSeleccionada))
                    {
                        case 1:
                            IngresarNuevaDivisa();
                            break;
                        case 2:
                            SeleccionarEditarDivisa();
                            break;
                        case 3:
                            Console.WriteLine("Divisas disponibles: ");
                            MostrarDivisa();
                            Regresar();
                            break;
                        case 4:
                            ConvertirDivisa();
                            break;
                        case 5:
                            Salir = false;
                            break;
                    }
                }
                catch
                { }

            }
        }
        public void IngresarNuevaDivisa()
        {
            var SalidaIngresoValores = true;
            var CodigoAgregarNuevaDivisa = "";
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese nuevo codigo de divisa: ");
                Console.WriteLine("");
                try
                {
                    CodigoAgregarNuevaDivisa = Console.ReadLine().ToUpper().Substring(0, 3);
                    if (CodigoAgregarNuevaDivisa.Length > 0 && CodigoAgregarNuevaDivisa.Length <= 3)
                        SalidaIngresoValores = false;
                }
                catch { }
            }

            SalidaIngresoValores = true;
            var ValorAgregarNuevaDivisa = 0.0;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Ingrese valor para " + CodigoAgregarNuevaDivisa + ": ");
                Console.WriteLine("");
                try
                {
                    ValorAgregarNuevaDivisa = double.Parse(Console.ReadLine());
                    if (ValorAgregarNuevaDivisa > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }
            CodigoDivisa.Add(CodigoAgregarNuevaDivisa);
            ValorDivisa.Add(ValorAgregarNuevaDivisa);

            Console.Clear();
            MostrarDivisa();
            Regresar();

        }
        public void SeleccionarEditarDivisa()
        {
            var SalirEditarDivisa = true;
            while (SalirEditarDivisa)
            {
                Console.WriteLine("Seleccionar la divisa a editar ");
                MostrarDivisa();
                int opcionRegresar = CodigoDivisa.Count() + 1;
                Console.Write(opcionRegresar + ". ");
                Console.WriteLine("Regresar");
                try
                {
                    var OpcionEditar = Console.ReadLine();
                    if ((int.Parse(OpcionEditar)) == opcionRegresar)
                    {
                        SalirEditarDivisa = false;
                    }
                    else
                    {
                        for (int i = 1; i <= CodigoDivisa.Count(); i++)
                        {
                            if ((int.Parse(OpcionEditar)) == i)
                            {
                                EditarDivisa(i);
                                SalirEditarDivisa = false;
                            }
                        }
                        
                    }
                }
                catch { Console.Clear(); }
            }
        }
        public void EditarDivisa(int OpcionEditar)
        {
            var SalidaIngresoValores = true;
            var CodigoNuevaDivisa = "";
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Datos de divisa Anterior Codigo:" + CodigoDivisa[OpcionEditar - 1] + " Valor:" + ValorDivisa[OpcionEditar - 1]);
                Console.WriteLine("Ingrese nuevo codigo: ");
                Console.WriteLine("");
                try
                {
                    CodigoNuevaDivisa = Console.ReadLine().ToUpper().Substring(0,3); 
                    if (CodigoNuevaDivisa.Length > 0 && CodigoNuevaDivisa.Length <= 3)
                        SalidaIngresoValores = false;
                }
                catch { }
            }

            SalidaIngresoValores = true;
            var ValorNuevaDivisa = 0.0;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.Clear(); Console.WriteLine("Datos de divisa Anterior Codigo:" + CodigoDivisa[OpcionEditar - 1] + " Valor:" + ValorDivisa[OpcionEditar - 1]);
                Console.WriteLine("Ingrese valor para " + CodigoNuevaDivisa + ": ");
                Console.WriteLine("");
                try
                {
                    ValorNuevaDivisa = double.Parse(Console.ReadLine());
                    if (ValorNuevaDivisa > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }
            CodigoDivisa[OpcionEditar - 1] = CodigoNuevaDivisa;
            ValorDivisa[OpcionEditar - 1] = ValorNuevaDivisa;

            Console.Clear();
            MostrarDivisa();
            Regresar();
        }

        public void MostrarDivisa()
        {
            Console.WriteLine("");
            for (int i = 1; i <= CodigoDivisa.Count(); i++)
            {
                Console.Write(i + ". Codigo:" + CodigoDivisa[i - 1]+ " Valor:");
                Console.WriteLine("{0:N2}",ValorDivisa[i - 1]);
            }
            Console.WriteLine("");
        }
        public void Regresar()
        {
            Console.WriteLine("");
            Console.WriteLine("Presione la tecla Enter para regresar.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        public void ConvertirDivisa()
        {
            
            var SalidaIngresoValores = true;
            var DivisaOrigen = 0;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Seleccionar divisa origen a utilizar");
                Console.WriteLine("");
                MostrarDivisa();
                try{
                    DivisaOrigen = int.Parse(Console.ReadLine())-1;
                    if ((DivisaOrigen+1) <= CodigoDivisa.Count&& (DivisaOrigen + 1)>0)
                        SalidaIngresoValores = false;

                }
                catch { }
            }


            SalidaIngresoValores = true;
            var DivisaDestino = 0;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Divisa Origen:" + CodigoDivisa[DivisaOrigen]);
                Console.WriteLine("Seleccionar divisa destino a utilizar");
                Console.WriteLine("");
                MostrarDivisa();
                try
                {
                    DivisaDestino = int.Parse(Console.ReadLine()) - 1;
                    if ((DivisaDestino + 1) <= CodigoDivisa.Count && (DivisaDestino + 1) > 0)
                        SalidaIngresoValores = false;

                }
                catch { }
            }

            SalidaIngresoValores = true;
            var CantidadConvertir = 0;
            while (SalidaIngresoValores)
            {
                Console.Clear();
                Console.WriteLine("Divisa Origen:" + CodigoDivisa[DivisaOrigen]);
                Console.WriteLine("Divisa Destino:" + CodigoDivisa[DivisaDestino]);
                Console.WriteLine("Ingrese de dinero a convertir: ");
                Console.WriteLine("");
                try
                {
                    CantidadConvertir = int.Parse(Console.ReadLine());
                    if (CantidadConvertir > 0)
                        SalidaIngresoValores = false;
                }
                catch { }
            }
            var CalculoFinal = CantidadConvertir * (ValorDivisa[DivisaDestino] / ValorDivisa[DivisaOrigen]);


            Console.Clear();
                Console.Write("Divisa Origen: "+ CodigoDivisa[DivisaOrigen] + "  ");
                Console.WriteLine("{0:N2}", ValorDivisa[DivisaOrigen]);
                Console.Write("Divida Destino: " + CodigoDivisa[DivisaDestino] + "  " );
                Console.WriteLine("{0:N2}", ValorDivisa[DivisaDestino]);
               Console.Write("Cantidad: ");
                Console.WriteLine("{0:N2}", CantidadConvertir);
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            Console.Write("Calculo Final: ");
                Console.WriteLine("{0:N2}", CalculoFinal);

                Regresar();
            
            
        }
    }
}
