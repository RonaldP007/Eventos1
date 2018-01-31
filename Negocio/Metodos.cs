using System.Collections.Generic;
using Datos;

namespace Negocio
{
    public class Metodos
    {
        public List<int> ComboBox()
        {
            List<int> lista = new List<int>();
            ClsConexion cn = new ClsConexion();
            lista = cn.ComboBox();

            return lista;
        }

        public List<object> Informacion(int cedula)
        {
            List<object> lista = new List<object>();
            ClsConexion cn = new ClsConexion();
            lista = cn.Informacion(cedula);

            return lista;
        }
    }
}
