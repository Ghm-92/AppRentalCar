using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRentalcar
{
    static class Connectdb
    {
        const string servidor = "localhost";
        const string banco = "rentalcar";
        const string usuario = "root";
        const string senha = "";

        public static string stringConexao = $"Server={servidor};" +
            $"Database={banco};User id={usuario};Password={senha}";
    }
}
