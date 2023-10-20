using System.Collections.Generic;

namespace Curso.Domain
{
    public class Departamento
    {
        public int ID {get;set;}
        public string Descricao {get;set;}
        public bool Ativo {get;set;}
        public bool Excluidos {get;set;}
        public List<Funcionario> Funcionarios {get;set;}

    }
}