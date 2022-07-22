using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Configurations
{
    public class SqlServerConfiguration
    {
        //método estático para retornar o valor da connectionstring do sqlserver
        public static string GetConnectionString()
        {
            // adicionar outro contra barra para o programa entender ou adicionar @ antes do "
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDProjetoAula05;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
