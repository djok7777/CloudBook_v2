using BibliotecaDeClases.Colecciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.BaseDatos
{
    public static class DatosBD
    {
        static ColeccionLibrosPublicados _listaPublicados = new ColeccionLibrosPublicados();
        static ColeccionLibrosComerciales _listaComerciales = new ColeccionLibrosComerciales();
        static ColeccionUsuarios _listaUsuarios = new ColeccionUsuarios();
        static List<String []> _msjContacto = new List<string []>();    //Guarda los mensajes desde la pagina contacto
        static bool cargado = false;    //Variable que controlará que se cargue 1 vez el método CargarDatos

        #region Propiedades
        public static ColeccionLibrosPublicados ListaPublicados
        {
            get
            {
                return _listaPublicados;
            }

            set
            {
                _listaPublicados = value;
            }
        }

        public static ColeccionLibrosComerciales ListaComerciales
        {
            get
            {
                return _listaComerciales;
            }

            set
            {
                _listaComerciales = value;
            }
        }

        public static ColeccionUsuarios ListaUsuarios
        {
            get
            {
                return _listaUsuarios;
            }

            set
            {
                _listaUsuarios = value;
            }
        }

        public static List<string[]> MsjContacto
        {
            get
            {
                return _msjContacto;
            }

            set
            {
                _msjContacto = value;
            }
        }
        #endregion

        #region Metodos
        public static void CargarDatos()
        {
            if (cargado == false)
            {
                CargarPublicados();
                CargarComerciales();
                CargarAdministradores();
                CargarUsuarios();
                cargado = true;
            }
        }

        //Carga publicaciones para pruebas
        public static void CargarPublicados()
        {
            Publicacion p1 = new Publicacion(1, "La neuroplasticidad", "Scist", 2017, CategoriaLibros.Ciencia, TipoContenido.Universal,
            "Sed feugiat, augue id sodales vestibulum, turpis arcu ultricies leo, at malesuada elit erat vitae tellus. Sed et sodales risus. Nullam ex justo, dignissim id libero at, rhoncus cursus nulla. Pellentesque hendrerit turpis quis justo bibendum placerat. Donec viverra justo eget dapibus sollicitudin. Nullam fringilla commodo tellus, ut ultricies nulla. Donec accumsan feugiat nunc a maximus.",
            777, 10, TipoEstado.Finalizado, TipoPeriodicidad.Mensual);
            p1.Ruta = "sample.pdf";
            p1.Portada = "La neuroplasticidad.jpg";
            Publicacion p2 = new Publicacion(2, "Viajes astrales", "Viajero", 2014, CategoriaLibros.Paranormal, TipoContenido.Universal,
            "Sed feugiat, augue id sodales vestibulum, turpis arcu ultricies leo, at malesuada elit erat vitae tellus.Sed et sodales risus.Nullam ex justo, dignissim id libero at, rhoncus cursus nulla.Pellentesque hendrerit turpis quis justo bibendum placerat.Donec viverra justo eget dapibus sollicitudin.Nullam fringilla commodo tellus, ut ultricies nulla.Donec accumsan feugiat nunc a maximus.", 
            700, 30, TipoEstado.Activo, TipoPeriodicidad.Mensual);
            p2.Portada = "Viajes astrales.jpg";
            Publicacion p3 = new Publicacion(3, "Justicia en tiempos de guerra", "Writter123", 2014, CategoriaLibros.Policial, TipoContenido.Adulto, "Sed feugiat, augue id sodales vestibulum, turpis arcu ultricies leo, at malesuada elit erat vitae tellus.Sed et sodales risus.Nullam ex justo, dignissim id libero at, rhoncus cursus nulla.Pellentesque hendrerit turpis quis justo bibendum placerat.Donec viverra justo eget dapibus sollicitudin.Nullam fringilla commodo tellus, ut ultricies nulla.Donec accumsan feugiat nunc a maximus.", 
            300, 0, TipoEstado.Activo, TipoPeriodicidad.Quincenal);
            p3.Portada = "Justicia en tiempos de guerra.jpg";

            ListaPublicados.Add(p1);
            ListaPublicados.Add(p2);
            ListaPublicados.Add(p3);
        }

        //Agrega libros del mercado
        private static void CargarComerciales()
        {
            Comercial c1 = new Comercial(4, "Inteligencia artificial", "Howard Selina", 1999, CategoriaLibros.Computación, TipoContenido.Universal, "La obra se dirige a los no especialistas, aunque científicos y filósofos hallarán novedades. El propósito consiste en explicar de manera clara de qué se trata cuando se habla de inteligencia artificial. Se elabora una descripción abstracta de lo que es una computadora, se enfrentan acertijos metafísicos acerca del significado de un universo material, se desenredan confusiones comunes acerca del lenguaje, el conocimiento, la personalidad, etcétera.",
            "1840464631", "Icon Books Ltd", 176);
            c1.Portada = "Inteligencia artificial.jpg";
            Comercial c2 = new Comercial(5, "Harry Potter y el prisionero de Azkaban", "J.K. Rowling", 2014, CategoriaLibros.Magia, TipoContenido.Infantil, 
            "Harry Potter y el prisionero de Azkaban es el tercero de los siete libros escritos de la serie Harry Potter, por J.K.Rowling. ...La trama del libro describe que un peligroso asesino, Sirius Black, se escapó de Azkaban, la prisión de los magos, y al parecer está dispuesto a encontrar y matar a Harry."
            ,"1408855682", "Bloomsbury Childrens; 01 edition", 640);
            c2.Ruta = "Harry_Potter_y_El_Prisionero_de_Azkaban_03.pdf";
            c2.Portada = "Harry Potter y el prisionero de Azkaban.jpg";
            c2.Audio = "harrypotteryelprisionerodeazkaban.mp3";
            Comercial c3 = new Comercial(6, "La ladrona de libros", "Markus Zusak", 2000, CategoriaLibros.Ficción_Contemporánea, TipoContenido.Juvenil,
            "La ladrona de libros, novela narrada desde el punto de vista de la Muerte, nos presenta a Liesel Meminger, una niña que se va a vivir con una familia adoptiva, compuesta por dos miembros, Hans y Rosa Hubermann, en un pueblo cercano a Múnich (Molching), en la Alemania anterior a la Segunda Guerra Mundial."
            ,"849062366X", "New edition", 544);
            c3.Portada = "La ladrona de libros.jpg";
            c3.Ruta = "La ladrona de libros.pdf";
            c3.Audio = "La ladrona de libros.mp3";
            Comercial c4 = new Comercial(7, "El señor de los anillos", "J. R. R. Tolkien", 1994, CategoriaLibros.Fantasía, TipoContenido.Juvenil,
            "El Anillo Único, alrededor de cuya destrucción gira la trama de la novela, sobre una página del libro. El Señor de los Anillos (título original en inglés: The Lord of the Rings) es una novela de fantasía épica escrita por el filólogo y escritor británico J. R. R. Tolkien."
            ,"0261103202", "HarperCollins Publishers", 1184);
            c4.Ruta = "El señor de los anillos.pdf";
            c4.Portada = "El señor de los anillos.jpg";
            c4.Audio = "El señor de los anillos.mp3";

            ListaComerciales.Add(c1);
            ListaComerciales.Add(c2);
            ListaComerciales.Add(c3);
            ListaComerciales.Add(c4);
        }

        //Carga usuarios para pruebas
        private static void CargarUsuarios()
        {
            CuentaUsuario user1 = new CuentaUsuario(3, "111", "111@hotmail.com", "111", "111", "111", "111");
            CuentaUsuario user2 = new CuentaUsuario(4, "222", "222@hotmail.com", "222", "222", "222", "222");
            CuentaUsuario user3 = new CuentaUsuario(5, "333", "333@hotmail.com", "333", "333", "333", "333");
            //Asignacion de publicaciones para un par de usuarios de prueba
            user1.Publicaciones.Add(ListaPublicados.First(p => p.IdLibro == 1));
            user1.Publicaciones.Add(ListaPublicados.First(p => p.IdLibro == 2));
            user3.Publicaciones.Add(ListaPublicados.First(p => p.IdLibro == 3));

            ListaUsuarios.Add(user1);
            ListaUsuarios.Add(user2);
            ListaUsuarios.Add(user3);
        }

        public static void CargarAdministradores() {
            CuentaUsuario user1 = new CuentaUsuario(1, "admin", "Jorge@hotmail.com", "admin", "Jorge", "Contreras", "Lanza");
            user1.Admin = true;
            CuentaUsuario user2 = new CuentaUsuario(2, "admin2", "Valentina@hotmail.com", "admin2", "Valentina", "Riveros", "Rojas");
            user2.Admin = true;
            ListaUsuarios.Add(user1);
            ListaUsuarios.Add(user2);
        }
        #endregion
    }
}
