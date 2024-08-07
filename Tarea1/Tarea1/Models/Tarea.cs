namespace Tarea1.Models
{
    public class Tarea
    {
        private int _id;
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        private string _nombre;
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        private string _descripcion;
        public string Descripcion
        {
            set { _descripcion = value; }
            get { return _descripcion; }
        }

        private int _duracionHoras;
        public int DuracionHoras
        {
            set { _duracionHoras = value; }
            get { return _duracionHoras; }
        }

        private string _responsable;
        public string Responsable
        {
            set { _responsable = value; }
            get { return _responsable; }
        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            set { _fecha = value; }
            get { return _fecha; }
        }

        public Tarea(int id, string nombre, string descripcion, int duracionHoras, string responsable, DateTime fecha)
        {
            this._id = id;
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._duracionHoras = duracionHoras;
            this._responsable = responsable;
            this._fecha = fecha;
        }

        public Tarea()
        {
        }
    }
}
