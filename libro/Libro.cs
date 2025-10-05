

using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Editorial // el namespace empieza con mayuscula(despues siguelowerCamelCase

{
    public class Libro // el nombre de la clase empiexa en mayuscula(despues siguelowerCamelCase
    {   //atributos(
        //ctor
        //propiedades
        //getter y setter
        // y el restos de los metodos
        //(atributos se repecta:
        //visibilidad - tipado- nombre(lowerCamelCase y sustantivo, singular salvo que sea colecciones)
        #region Attributes

        //DATOS BIBLIOGRAFICOS
        private string titulo;//(atributos)
        private string autor;
       // private string genero;
        private string edicion;//(primera, segunda, revisada, ampliada, etc.)
        private int añoDePublicacion;
        private string editorial;
        private int numeroDePagina;
        private int dimensiones;//(ej: 15x23 cm, A5, bolsillo)
        private string tipoDeEncuadenacion;//(rústica, tapa dura, espiral, cosida, etc.)
        private double precioDeVenta;//(sugerido o fijado por editorial)
        private List<Genero> generoElegido;
        //private List<Libro>
        ////CONTENIDO DEL LIBRO
        //private string prologoPrefacio;
        //private string indiceOTablaDeContenido;
        //private string CapitulosOSecciones;
        //private string notasAlPie;
        //private string bibliografia;
        //private string glosarioDeTerminos;
        //private string apendicesAnexos;


        ////DISEÑO Y ASPECTOS GRAFICOS
        //private string diseñoDePortada;//(imagen, ilustración, fotografía, tipografía)
        //private string contraportada;//(resumen de la obra, reseña crítica, biografía del autor)
        //private string lomo; //(título, autor, editorial, logotipo)
        //private string tipografiaInterior;//(tipo de letra, tamaño, interlineado)
        //private double margenesYMaquetacion;//Superior,inferior,Izquierda, derecha
        //private string tipoDePapel;//(blanco, ahuesado, ilustración, reciclado, gramaje)
        //private string color;//(interior en blanco y negro o a color)
        //private string imagenes;//(ilustraciones, gráficos o tablas y se guarda la direccion Ejemplo: "C:\\Libros\\portada.jpg"

        ////INFORMACION DEL AUTOR
        //private string nombreCompleto;
        //private string biografiaBreve;//(para contraportada o solapa)
        //private string fotoDelAutor;//(opcional, en solapa o contratapa)
        //private string redesSociales;//contacto(si se incluye en promoción)

        //// ASPECTO LEGALES
        //private string derechoDeAutor;//(copyright)
        //private string licenciaOTipoDeUso;//(ej: Creative Commons, dominio público, todos los derechos reservados)
        //private Guid NumeroDeContrato;//(si corresponde) se utiliza  Guid cuando los contratos lleva numeros y letras
        #endregion


        #region CTOR
        public Libro()
        {
           
        }
        public Libro(string titulo, string autor)// (ctor)
        {
            this.titulo = titulo;
            this.autor = autor;


        }
        //public Libro(string titulo, int año)// (ctor)
        //{
        //    this.titulo = titulo;
        //    this.año = año;

        //}
        //public Libro( int año, string titulo)// (ctor) (para hacer el mismo constructor los parametros tienen que estar
        //                                     // en la misma ubicacion a diferencia con el de arriba empieza con string
        //                                     // y este con int (aunque tenga dos tipos de parametros iguales la ubicacion
        //                                     // no es la misma
        //{

        //    this.año = año;
        //    this.titulo = titulo;

        //}
        #endregion
        //public void CargarUnaCadena(string valor) //(ahora se reemplaza por set)
        //{
        //    this.color = valor;
        //}

        //public string ConsultaDeCargarCadena()// (ahora se reemplaza por get)
        //{ return this.color; }


        #region Setters
        public string Titulo 
        {
            get
            {
                
                return this.titulo;
            }
            set

            {

                
                   if  (!string.IsNullOrEmpty(value))
                    { 
                        this.titulo = value;
                    }
                
            }
        }
        public string Autor
        {
            get
            {
                return this.autor;
            }
        }
        public int AñoDePublicacion
        {
            get
            {
                return this.añoDePublicacion;
            }
            set
            {
                { this.añoDePublicacion = value; }
            }
        }
        //public string Genero
        //{
        //    get
        //    {
        //        return this.genero;
        //    }
        //    set
        //    {
        //        switch (value)
        //        {
        //            case "Fantasia":
        //                this.genero = value;
        //                break;
        //            case "CienciaFiccion":
        //                this.genero = value;
        //                break;
        //            case "Terror":
        //                this.genero = value;
        //                break;
        //            case "Misterio":
        //                this.genero = value;
        //                break;
        //            case "Romance":
        //                this.genero = value;
        //                break;
        //            case "Historico":
        //                this.genero = value;
        //                break;
        //            case "Biografia":
        //                this.genero = value;
        //                break;
        //            case "Infantil":
        //                this.genero = value;
        //                break;
        //            case "Juvenil":
        //                this.genero = value;
        //                break;

        //            default:
        //                this.genero = "No Existenete"; // por defecto
        //                break;
        //        }
        //    }
        //}  

        

        //public string Genero
        //{
        //   get 
        //   {
        //       return this.genero;
        //   }
        //   set
        //   {
        //       if (!string.IsNullOrEmpty(value) &&( value == "femenino" ||value == "masculino" || value == "otro"))
        //       { this.genero = value; }
        //   }
        //}
        public string Edicion
         {
            get
            {
                return this.edicion;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    { this.edicion = value; }
            }
         }
         public string Editorial
         {
            get
            {
                return this.editorial;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.editorial = value;
            }
         }
         
         public int NumeroDePagina
         {
            get
            {
                return this.numeroDePagina;

            }
            set
            {
                this.numeroDePagina = value;
            }
         }
         public int Dimensiones
         {
            get
            {
                return this.dimensiones;

            }
            set
            {
                this.dimensiones = value;
            }

         }
         public string TipoDeEncuadernacion
         {
            get
            {
                
                    return this.tipoDeEncuadenacion;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)  )
                    this.tipoDeEncuadenacion = value;
            }
           
         }
         public double PrecioDeVenta
         {
            get
            {
                return this.precioDeVenta;
            }
            set
            {
                this.precioDeVenta = value;
            }
         }
        
        

















        //public void SetTitulo(string titulo)
        //{
        //    this.titulo = titulo;
        //}
        //public void SetAutor(string autor)
        //{
        //    this.autor = autor;
        //}
        //public void SetAñoDePublicacion(int añoDePublicacion)
        //{
        //    this.añoDePublicacion = añoDePublicacion;
        //}
        #endregion

        #region Getters
        //public string GetTituloCompleto()
        //{ return this.titulo; }
        //public string GetAutor()
        //{ return this.autor; }
        //public int GetAñoDePublicacion()
        //{ return this.añoDePublicacion; }
        #endregion



        public string MostrarLibro()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titulo:" + this.titulo );
            sb.AppendLine("Autor: " + this.autor);
            sb.AppendLine("Genero: " + this.genero);
            sb.AppendLine("Edicion: " + this.edicion);
            sb.AppendLine("Año De Publicacion: " + this.añoDePublicacion);
            sb.AppendLine("Editorial: " + this.editorial);
            sb.AppendLine("Numero de Paginas: " + this.numeroDePagina);
            sb.AppendLine("Dimensiones: " + this.dimensiones);
            sb.AppendLine("Tipo de Encuadernacion: " + this.tipoDeEncuadenacion);
            sb.AppendLine("Ptrecio De Venta: " + this.precioDeVenta);

            return sb.ToString();

        }

        public string MostrarLibroNuevo()
        {
            string mostrar;
            int añoEdicion = 2000;
            if (añoDePublicacion == 0)
            {
                mostrar = "cero no es valido";
            }

            if (añoDePublicacion > añoEdicion)

            {
                mostrar = $"Libro  despues del{añoEdicion}, {titulo}, ({añoDePublicacion})";
            }

            else
            {
                mostrar = $"Libro  antes del {añoEdicion}, {titulo}, ({añoDePublicacion})";

            }
            return mostrar;
        }
        public class Biblioteca
        {
            private List<Libro> libros = new List<Libro>();

            // Método para agregar un libro
            public void AgregarLibro(Libro libro)
            {
                libros.Add(libro);
            }

            // Método para mostrar todos los libros
            public void MostrarLibros()
            {
                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.MostrarLibro());
                }
            }

        }
}
//    def pedir_numero_menu(mensaje, valor_minimo, valor_maximo):
//    resultado =  int (input(mensaje))      
//    while resultado<valor_minimo or resultado > valor_maximo:
//        print(f"Valor fuera de rango, debe estar entre {valor_minimo} y {valor_maximo}")
//        resultado =  int (input(mensaje))
//    return resultado

//def pedir_nombre(lista:list, cuantos_datos, mensaje)->str:
  
        
//    for i in range(cuantos_datos) :
//        resultado=str(input(mensaje))
//    lista.append(resultado)  
//    return resultado


//def buscar_un_nombre(lista:list, nombre_buscado, mensaje) :
//    # while resultado != "":
//    #     resultado=str (input(mensaje))  
//    # lista.append(resultado) 
   
    

    
//    for i in range(len(lista)) :
//        if lista[i]== nombre_buscado:
//           nombre_encontrado = nombre_buscado 
//        else:
//           nombre_encontrado ="nombre no encontrado" 
   

//    return nombre_encontrado


//def obtener_indice(lista:list, nombre_buscado) :
//    posicion = -1
//    for i in range(len(lista)) :
//        if lista[i]== nombre_buscado:
//            posicion = i  
//            break
//    if posicion == -1:
//        print(" el nombre buscado no se encuentra en la lista")
                  
//    return posicion

//def contar_cuantas_veces_aparece_un_nombre(lista:list, nombre_buscado) :


//    contador_nombres = 0
//    for i in range(len(lista)) :
//        if lista[i]== nombre_buscado:
            
//            contador_nombres+=1
//            break                 
//    return contador_nombres

//def mostrar_lista(lista:list) :  #➢ mostrar_lista(lista): muestra la lista que recibe por parámetro, no retorna nada

//    for i in range(len(lista)) :
//        print(lista[i])

//def mostrar_todos_los_alumnos_que_se_llama(lista:list, nombre_buscado):#➢ mostrar_lista(lista): muestra la lista

//     for i in range(len(lista)) :
//        if lista[i]==nombre_buscado:
//            print(lista[i])
//def verificar_carga_de_lista(lista:list, cuantos_datos, mensaje):
//    bandera_carga_lista=False
//    while lista ==[] or bandera_carga_lista==True:

//        print("lista vacia")
//        pedir_nombre(lista, cuantos_datos, mensaje)
//        bandera_carga_lista=True
//        break
        
//    return True
    