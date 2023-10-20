using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Curso.Interceptadores
{
    public class interceptadorDeConexao : DbConnectionInterceptor
    {
        public override InterceptionResult ConnectionOpening(
            DbConnection connection,
            ConnectionEventData eventData,
            InterceptionResult result)
            {
                var connectionString = ((SqlConnection)connection).ConnectionString; // Recupera a string original q foi configurada com base no OnConfiguring
                var connectionStringBuilder = new SqlConnectionStringBuilder(connectionString)
                {
                    //DataSource = "IP Segundo Servidor" Aqui podemos mudar o IP do servidor 
                    ApplicationName = "CursoEFCore" // Apenas mudando o Nome da aplicação 
                };

                connection.ConnectionString = connectionStringBuilder.ToString();
                return result;

            }
        
    }
}