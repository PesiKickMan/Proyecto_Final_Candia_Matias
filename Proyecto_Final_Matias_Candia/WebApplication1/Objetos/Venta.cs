namespace Proyecto_Final.Objetos
{
    public class Venta
    {
        private long _Id;
        private string _Comentarios;

        public Venta()
        {
            this._Id = 0;
            this._Comentarios = String.Empty;
        }

        public Venta(long id, string comentarios)
        {
            this._Id = id;
            this._Comentarios = comentarios;
        }

        public long Id { get { return _Id; } set { _Id = value; } }
        public string Comentarios { get { return _Comentarios; } set { _Comentarios = value; } }
    }
}
