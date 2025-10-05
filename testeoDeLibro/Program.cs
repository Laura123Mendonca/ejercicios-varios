using Editorial;
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

            
                
            
            //Libro primerLibro = new Libro(" El Principito ", "AntoineDeSaintExupery ");
            //// la clase como tal paso hacer un tipo de dato primerlibro y para que exista primerlibro tengo que usar el construc_
            ////-tor de la clase  con new libro("ElPrincipito", "AntoineDeSaintExupery");
            //Libro cuartoLibro = new Libro("Rayuela", "Cortaza");
            //Console.WriteLine($"Titulo: {primerLibro.Titulo} - autor: {primerLibro.Autor}");

            ////Libro quintoLibro = new Libro("El Alquimista", "Paulo Cohelo");


            //// Libro segundoLibro = new Libro();

            //// Libro tercerLibro;
            ////  int libroNuevo2000;

            ////Console.WriteLine(primerLibro.MostrarLibro());
            ////Console.WriteLine(cuartoLibro.MostrarLibro());

            ////Console.WriteLine(quintoLibro);
            //primerLibro.Titulo = "";
            //primerLibro.AñoDePublicacion = 1943;
            //    ;
            //     ;
            ////quintoLibro.AñoDePublicacion = 1988;
            ////Console.WriteLine(quintoLibro);
            
            //Console.WriteLine(primerLibro.MostrarLibro());
            //Console.WriteLine(cuartoLibro.MostrarLibro());
            ////Console.WriteLine(quintoLibro.MostrarLibro());
            //Console.WriteLine(primerLibro.MostrarLibroNuevo());
            //Console.WriteLine(cuartoLibro.MostrarLibroNuevo());
            ////Console.WriteLine(quintoLibro.MostrarLibroNuevo());
            ////para llamar una propiedad
            ////Libro l = new Libro();
            ////l.Titulo = "El Principito";   // usa el set
            ////Console.WriteLine(l.Titulo);  // usa el get
            //Libro libroSexto = new Libro("Platero y yo" , "Juan Ramon Jimenez");
            //libroSexto.Genero = "caramelo";
            //Console.WriteLine(libroSexto.Genero);
            //Console.WriteLine(libroSexto.MostrarLibro());
            //Console.WriteLine(libroSexto.Genero);
            //// Console.WriteLine(quintoLibro.MostrarLibroNuevo());

            ////primerLibro.MostrarLibro();
            ////Console.WriteLine(primerLibro.prestamo);esto funciona cuando esta en public


            ////primerLibro.prestamo = true;
            ////Console.WriteLine(primerLibro.prestamo); esto funciona cuando esta en public


            //// segundoLibro.MostrarLibro();

            //if (primerLibro.AñoDePublicacion <= 1943)
            //{
            //    Console.WriteLine($"Libro  antes del 2000,{primerLibro.Titulo}");
            //}
            //else
            //{
            //    Console.WriteLine($"Libro  despues del 2000");
            //}

        



    






