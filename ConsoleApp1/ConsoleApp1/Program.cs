namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ﻿using Editorial;
using System.Linq.Expressions;
using System.Text;

namespace testeoDeLibro
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string titulo;//(atributos)
            string autor;
            string genero;
            string edicion;//(primera, segunda, revisada, ampliada, etc.)
            int añoDePublicacion;
            string editorial;
            int numeroDePagina;
            int dimensiones;//(ej: 15x23 cm, A5, bolsillo)
            string tipoDeEncuadenacion;//(rústica, tapa dura, espiral, cosida, etc.)
            double precioDeVenta;
            string ingresarDato;
            string ingreseNumeroDeTarea;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listado de tareas que puede completar o modificar");
            sb.AppendLine("1_ Titulo");
            sb.AppendLine("2_ Autor");
            sb.AppendLine("3_ Genero");
            sb.AppendLine("4_ Edicion");
            sb.AppendLine("5_ Año de Publicación");
            sb.AppendLine("6_ Editorial");
            sb.AppendLine("7_ Numero de Pagina");
            sb.AppendLine("8_ Dimensiones");
            sb.AppendLine("9_ Tipo de Encuadernacion");
            sb.AppendLine("10_ Precio de Venta");
            sb.AppendLine("11_ Salir");
            Libro primerLibro = new Libro();

            Console.WriteLine(sb.ToString());

            do
            {



                Console.WriteLine($"Quiere ingresar algun dato: (s/n)");
                ingresarDato = Console.ReadLine();


            }

            while (ingresarDato != "s");


            do
            {
                Console.WriteLine($"Ingrese el numero de tarea que quiere realizar");
                ingreseNumeroDeTarea = (Console.ReadLine());
            }
            while (ingreseNumeroDeTarea != "1"&& ingreseNumeroDeTarea != "2" && ingreseNumeroDeTarea != "3 "&& ingreseNumeroDeTarea != "4" &&
            ingreseNumeroDeTarea != "5" && ingreseNumeroDeTarea != "6" && ingreseNumeroDeTarea != "7" && ingreseNumeroDeTarea != "8" && ingreseNumeroDeTarea != "9" && ingreseNumeroDeTarea != "10" && ingreseNumeroDeTarea!="11");
            if (ingreseNumeroDeTarea == "1")
            { 
                 

                    Console.WriteLine($"Ingrese el titulo: " );
                    primerLibro.Titulo= Console.ReadLine();
                Console.WriteLine(primerLibro.MostrarLibro());

            }



            Console.WriteLine($"Fin de tarea");
            console.WriteLine($"funciona el git");
        }
    }
}
