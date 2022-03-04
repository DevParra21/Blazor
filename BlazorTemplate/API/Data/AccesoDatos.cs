using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class AccesoDatos
    {
        private string _cadenaSQL;

        public string CadenaSQL { get => _cadenaSQL; }

        public AccesoDatos(string m_conn)
        {
            _cadenaSQL = m_conn;
        }
    }
}
