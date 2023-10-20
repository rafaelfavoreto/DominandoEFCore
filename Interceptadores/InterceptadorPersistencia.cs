using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Curso.Interceptadores
{
    public class InterceptadorPersistencia : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(
            DbContextEventData eventData,
            InterceptionResult<int> result
        )
        {
            return result;
        }
    }
}