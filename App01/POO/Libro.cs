namespace App01.POO
{
    public class Libro
    {

        string _nombre;
        string _autor;
        int _cantidadPaginas;

        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public Libro()
        {
            _nombre = "Sin nombre";
            _autor = "Sin autor";
            _cantidadPaginas = 0;
        }


        public string GetDescripcion()
        {
            return $"Nombre: {_nombre}, Autor: {_autor}, Páginas: {_cantidadPaginas}";
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public int CantidadPaginas
        {
            get { return _cantidadPaginas; }
            set { _cantidadPaginas = value; }
        }

        public override string ToString()
        {
            return GetDescripcion();
        }
    }
}
