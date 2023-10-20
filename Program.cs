using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(var db  = new Curso.Data.ApplicationContext())
            {
                var teste = db.Departamentos.AsNoTracking().Where(p=> EF.Functions.Like(p.Descricao, "%A%"));
            } 

        }
    }
}
