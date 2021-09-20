using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Models
{
    public class Categoria
    {

        protected Categoria() =>
            Livros = new List<Livro>();

        public Categoria(int id,string nome) : this()
        {
            ID = id;
            Nome = nome;
        }

        public int ID{ get; set; }

        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
