using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro
{
    public class Produtos
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public Produtos(string nome, float preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public void ExibirProduto()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Quantidade: {Quantidade}");
        }
    }
}
