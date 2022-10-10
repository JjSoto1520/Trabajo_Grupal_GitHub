using System;
using System.CodeDom;

namespace Trabajo_Grupal_GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int opc = 0;



            // Intancias de clases

            Calculo_Matricula Calculo_Matricula = new Calculo_Matricula();
            Calculo_Peso_Paquete Calculo_Peso_Paquete = new Calculo_Peso_Paquete();
            Calculo_Salario calculo_Salario = new Calculo_Salario();



            while (opc != 5) //Menu de opciones
            {
                try
                {
                    Console.WriteLine("Opcion 1: Calculo de Matricula.");
                    Console.WriteLine("Opcion 2: Calculo de Peso Paquete.");
                    Console.WriteLine("Opcion 3: Calculo de Salario.");
                    Console.WriteLine("Opcion 4: Calculo de Area del Terreno.");
                    Console.WriteLine("Opcion 5: Salir.");



                    opc = int.Parse(Console.ReadLine());
                    int mat_teorica;
                    int mat_practica;
                    int matricula = 5000;
                    double total_pagar, total_salario, area_terreno;


                    switch (opc)
                    {
                        case 1:

                            Console.WriteLine(" Digite su Numero de Cedula: ");
                            double cedula = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite cantidad de materias Teoricas: ");
                            mat_teorica = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite cantidad de materias Teoricas: ");
                            mat_practica = int.Parse(Console.ReadLine());

                            total_pagar = (mat_teorica * 1000) + (mat_practica * 2000) + matricula;

                            Console.WriteLine("El monto a pagar es:" + total_pagar);
                            Console.WriteLine("");

                            break;

                        case 2:

                            Console.WriteLine(" Digite el peso en Kilos del Paquete: ");
                            int peso = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite el Valor del Contenido del Paquete: ");
                            int valor = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite la Distancia en Kilometros del Viaje: ");
                            int distancia = int.Parse(Console.ReadLine());

                            total_pagar = (peso * 100) + ((valor * 10) / 100) + (distancia * 500);

                            Console.WriteLine("El monto a pagar es:" + total_pagar);

                            Console.WriteLine("");

                            break;

                        case 3:

                            Console.WriteLine(" Digite el salario Hora del Trabajador: ");
                            int salario = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite la cantidad de horas laboradas: ");
                            int horas = int.Parse(Console.ReadLine());

                            total_salario = (salario * horas);
                            total_pagar = total_salario - ((total_salario * 9) / 100);

                            Console.WriteLine("El monto a pagar es:" + total_pagar);

                            Console.WriteLine("");

                            break;

                        case 4:
                            Console.WriteLine(" Digite el largo del Terreno: ");
                            int largo = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite el ancho del Terreno: ");
                            int ancho = int.Parse(Console.ReadLine());

                            area_terreno = (ancho * largo);

                            if (area_terreno>=100)
                            {
                                Console.WriteLine("El area del terreno es: " + area_terreno);
                                Console.WriteLine("El terreno es Apto para Construir");

                            }
                            else if (area_terreno<100)
                            {
                                Console.WriteLine("El area del terreno es: " + area_terreno);
                                Console.WriteLine("El terreno no es Apto para Construir");

                            }

                            Console.WriteLine("");

                            break;

                        case 5:
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe digitar un numero del Menu");

                }

            }

            Console.WriteLine("\n" +
                    "*****************************************************\n" +
                    "*Muchas gracias !! Digite cualquier tecla para salir*" +
                  "\n*****************************************************");
            Console.ReadKey();

        }
    }
}
