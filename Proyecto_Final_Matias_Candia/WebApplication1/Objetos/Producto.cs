namespace Proyecto_Final.Objetos
{
    public class Producto
    {
        private long _Id;
        private string _Descripciones;
        private double _Costo;
        private double _PrecioVenta;
        private int _Stock;
        private long _IdUsuario;

        public Producto()
        {
            this._Id = 0;
            this._Descripciones = String.Empty;
            this._Costo = 0.0;
            this._PrecioVenta = 0.0;
            this._Stock = 0;
            this._IdUsuario = 0;
        }

        public Producto(long id, string descripciones, double costo, double precioVenta, int stock, long idUsuario)
        {
            this._Id = id;
            this._Descripciones = descripciones;
            this._Costo = costo;
            this._PrecioVenta = precioVenta;
            this._Stock = stock;
            this._IdUsuario = idUsuario;
        }

        public long Id { get { return _Id; } set { _Id = value; } }
        public string Descripciones { get { return _Descripciones; } set { _Descripciones = value; } }
        public double Costo { get { return _Costo; } set { _Costo = value; } }
        public double PrecioVenta { get { return _PrecioVenta; } set { _PrecioVenta = value; } }
        public int Stock { get { return _Stock; } set { _Stock = value; } }
        public long IdUsuario { get { return _IdUsuario; } set { _IdUsuario = value; } }
    }
}
