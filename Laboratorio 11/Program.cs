using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_11
{
    class Program
    {
        static int[] notes = new int[100];
        static int grades = 0;

        static void Main()
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Casos con arreglos");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar notas");
                Console.WriteLine("2: Hallar la nota mayor");
                Console.WriteLine("3: Hallar la nota menor");
                Console.WriteLine("4: Encontrar una nota");
                Console.WriteLine("5: Modificar una nota");
                Console.WriteLine("6: Ver notas registradas");
                Console.WriteLine("7: Salir");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese una opción:");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Registrar();
                        break;
                    case 2:
                        Mayor();
                        break;
                    case 3:
                        Menor();
                        break;
                    case 4:
                        Buscar();
                        break;
                    case 5:
                        Modificar();
                        break;
                    case 6:
                        VerNota();
                        break;
                }
            } while (option != 7);
        }

        static void Registrar()
        {
            Console.Clear();
            Console.WriteLine("================================\n" +
                "Registrar una nota\n" +
                "================================");
            do
            {
                Console.Write("Ingresar nota Nro " + (grades + 1) + ": ");
                notes[grades] = int.Parse(Console.ReadLine());
                grades++;
                Console.WriteLine("1: Registrar otra nota");
                Console.WriteLine("2: Regresar");
                int option = int.Parse(Console.ReadLine());
                if (option != 1)
                    break;
            } while (grades < notes.Length);
        }

        static void Mayor()
        {
            Console.Clear();
            int higher = -1;
            for (int i = 0; i < grades; i++)
            {
                if (notes[i] > higher)
                {
                    higher = notes[i];
                }
            }
            Console.WriteLine("===============================\n" +
                "La nota mayor\n" +
                "================================");
            Console.WriteLine("La nota mayor es: " + higher +
                "================================" +
                "1: Regresar");
            Console.ReadLine();
        }

        static void Menor()
        {
            Console.Clear();
            int minor = int.MaxValue;
            for (int i = 0; i < grades; i++)
            {
                if (notes[i] < minor)
                {
                    minor = notes[i];
                }
            }
            Console.WriteLine("===============================\n" +
                 "La nota menor\n" +
                 "================================");
            Console.WriteLine("La nota menor es: " + minor +
                "================================"+
                "1: Regresar");
            
            Console.ReadLine();
        }

        static void Buscar()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                "Buscar Nota\n" +
                "================================");
            Console.Write("Ingresar nota a buscar: ");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < grades; i++)
            {
                if (notes[i] == search)
                {
                    Console.WriteLine("La nota está en la posición " + i);
                }
            }
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void Modificar()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                "Modificar Nota\n" +
                "================================");
            Console.Write("Ingresar posición: ");
            int position = int.Parse(Console.ReadLine()) - 1;
            if (position >= 0 && position < grades)
            {
                Console.Write("Ingrese el nuevo valor: ");
                notes[position] = int.Parse(Console.ReadLine());
                MostrarNota(position);
            }
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void VerNota()
        {
            Console.Clear();
            Console.WriteLine("===============================\n" +
                "notas registradas\n" +
                "================================");
            MostrarNota();
            Console.WriteLine("1: Regresar");
            Console.ReadLine();
        }

        static void MostrarNota(int Position = -1)
        {
            Console.Clear();
            for (int i = 0; i < grades; i++)
            {
                if (i == Position)
                {
                    Console.Write("[" + notes[i] + "] ");
                }
                else
                {
                    Console.Write(notes[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
