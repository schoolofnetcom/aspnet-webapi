using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProdutoController : ApiController
    {
        public Produto[] produtos = new Produto[] { 
            new Produto() { Codigo = 1, Nome = "Nokia Lumia", Categoria = "Celulares", Valor = 699.99M },
            new Produto() { Codigo = 2, Nome = "Samsung Galaxy", Categoria = "Celulares", Valor = 1199.99M },
            new Produto() { Codigo = 3, Nome = "Teclado", Categoria = "Informatica", Valor = 130.00M },
            new Produto() { Codigo = 4, Nome = "Mouse", Categoria = "Informatica", Valor = 59.95M },
            new Produto() { Codigo = 5, Nome = "Case GoPro", Categoria = "Acessorios", Valor = 65.00M },
        };

        //GET = Selects
        

        public IEnumerable<Produto> GetTodos()
        {
            return produtos;
        }

        public IHttpActionResult Get(int codigo)
        {
            var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
            if (produto == null) return NotFound();
            return Ok(produto);
            //return Json<Produto>(produto);
        }

        public IEnumerable<Produto> GetPorCategoria(string categoria)
        {
            return produtos.Where(p => string.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase));
        }

        //POST = Insert
        public void Post([FromBody] Produto produto)
        {
            //realiza o cadastro de produto com base no parametro recebido
        }

        //PUT = Insert ou Update
        public void Put([FromBody] Produto produto)
        {
            //realiza o cadastro/atualização de produto com base no parametro recebido
        }

        //DELETE = Delete
        public void Delete(int codigo)
        {
            //realiza exclusão de um produto com base no código recebido
        }
    }
}
