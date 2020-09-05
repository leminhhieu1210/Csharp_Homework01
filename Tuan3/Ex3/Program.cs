using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr a = new Arr();

            a.input();
            a.output();

            Console.Write("\n\nMang sap xep tang dan: ");
            a.sapxep(0);
            a.output();

            Console.Write("\nVi tri cua gia tri 3: " + a.timkiem(3));
        }
    }
}
