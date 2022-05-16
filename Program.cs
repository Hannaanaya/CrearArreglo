using System;

namespace Ejercicio1_CrearArreglo
{
    class Program
    {
        private int[] arreglo;

        public void IngresarLongitud()
        {
            Console.Write("Ingresa longitud del arreglo: ");
            string cadena;
            cadena = Console.ReadLine();
            int num;
            num = int.Parse(cadena);
            arreglo = new int[num];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("Ingresa el numero " + (i + 1) + ": ");
                cadena = Console.ReadLine();
                arreglo[i] = int.Parse(cadena);
            }
        }
        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < arreglo.Length; a++)
                for (int b = arreglo.Length - 1; b >= a; b--)
                {
                    if (arreglo[b - 1] > arreglo[b])
                    {
                        t = arreglo[b - 1];
                        arreglo[b - 1] = arreglo[b];
                        arreglo[b] = t;
                    }
                }
        }

        public void ImprimirContenido()
        {
            Console.WriteLine("\nContenido del arreglo");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "  ");
            }
            Console.ReadKey();
        }

        public void Buscar(int num)
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;
            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (arreglo[m] == num)
                    found = true;
                if (arreglo[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); }
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); }
        }
        public void ImprimirBusqueda()
        {
            for (int i = 0; i > arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "  ");
            }
        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.IngresarLongitud();
            pv.MetodoBurbuja();
            pv.ImprimirContenido();
            pv.ImprimirBusqueda();
            Console.Write("\n\nIngrese elemento que desea buscar en el arreglo: ");
            int num = int.Parse(Console.ReadLine());
            pv.Buscar(num);
       
            Console.ReadKey();
        }
    }
}
