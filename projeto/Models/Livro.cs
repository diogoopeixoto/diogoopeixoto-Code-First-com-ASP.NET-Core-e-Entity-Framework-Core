using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Models
{
    public class Livro
    {
        public Livro() =>
            DataEntrada = DateTime.Now;
        public Livro(int id, int categoriaID, string titulo, string autor, string quantidade, decimal preco, DateTime dataEntrada) : this()
        {
            ID = id;
            CategoriaID = categoriaID;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            DataEntrada = dataEntrada;
        }

        public int ID { get; set; }

        public int CategoriaID { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Quantidade { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataEntrada { get; set; }

        public Categoria Categoria { get; set; }
    }
}
