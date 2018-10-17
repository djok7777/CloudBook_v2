using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + new string('=', 20) + "DATOS SIN PARAMETROS" + new string('=', 20));
            PruebaDatosSinParametro();
            Console.WriteLine("\n" + new string('=',20) + "DATOS CON PARAMETROS" + new string('=', 20));
            PruebaDatosConParametro();

            Console.ReadKey();
        }

        public static void PruebaDatosSinParametro(){
            Comercial comercial1 = new Comercial();
            Publicacion publicacion1 = new Publicacion();
            AudioBook audio1 = new AudioBook();
            CuentaUsuario usuario1 = new CuentaUsuario();

            Console.WriteLine("\n-LIBRO COMERCIAL" + comercial1.ToString());
            Console.WriteLine("\n-LIBRO PUBLICADO" + publicacion1.ToString());
            Console.WriteLine("\n-LIBRO EN AUDIO" + audio1.ToString());
            Console.WriteLine("\n-DATOS DE USUARIO : " + usuario1.ToString());
        }

        private static void PruebaDatosConParametro()
        {
            Comercial comercial1 = new Comercial(1, "Harry Potter", "J.K. Rowling", 1997,
                CategoriaLibros.Magia, TipoContenido.Juvenil, "123-456-7-89", "Bloomsbury ", 300);
            Publicacion publicacion1 = new Publicacion(10001, "Publicacion Indie", "Someone", 2017,
                CategoriaLibros.Policial, TipoContenido.Adulto, 500, 233, TipoEstado.Activo, TipoPeriodicidad.Mensual);
            AudioBook audio1 = new AudioBook(100001, "El Alquimista", "Paulo Coelho", 1988, CategoriaLibros.Misterio,
                TipoContenido.Juvenil, "123-41245-0", "Planeta", 45000, "mp3", "SomeOneCool");
            CuentaUsuario usuario1 = new CuentaUsuario(1, "SomeOne", "Is", "Happy", "someoneishappy@gmail.com", "someppy", "smoesapy123", null, null);

            Console.WriteLine("\n-LIBRO COMERCIAL" + comercial1.ToString());
            Console.WriteLine("\n-LIBRO PUBLICADO" + publicacion1.ToString());
            Console.WriteLine("\n-LIBRO EN AUDIO" + audio1.ToString());
            Console.WriteLine("\n-DATOS DE USUARIO : " + usuario1.ToString());
        }
    }
}
