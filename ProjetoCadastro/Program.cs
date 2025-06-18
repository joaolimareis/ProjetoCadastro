using ProjetoCadastro;
using System;
using System.Collections.Generic;
string boasVindas = "Seja Bem-Vindo(a).";
List<Cadastro> clientes = new List<Cadastro>();
List<Produtos> produtos = new List<Produtos>();

void MensagemIncial()
{
    Console.WriteLine(boasVindas);
}
void MenuPrincipal()
{
    MensagemIncial();
    Console.WriteLine(" ");
    
    Console.WriteLine("1 - Cadastrar um Cliente");
    Console.WriteLine("2 - Cadastrar um Produto ");
    Console.WriteLine("3 - Listar Clientes ");
    Console.WriteLine("4 - Listar Produtos ");
    Console.WriteLine("5 - Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoInt = int.Parse(opcao);
    

    switch (opcaoInt)
    {
        case 1:
            CadastroCliente();
            break;
        case 2:
            CadastroProdutos();
            break;
        case 3:
            ListarClientes();
            break;
        case 4:ListarProdutos();
            break;
        case 5: Console.WriteLine("Saindo...");
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
}
MenuPrincipal();

void CadastroCliente()

{
    
    Console.WriteLine("Digite o nome do cliente: ");
    string Nome = Console.ReadLine()!;
    Console.Write("Digite o email do cliente: ");
    string Email = Console.ReadLine()!;
    Console.Write("Digite o telefone do cliente: ");
    string Telefone = Console.ReadLine()!;
    Console.WriteLine(" ");

    Cadastro novoCliente = new Cadastro(Nome, Email, Telefone);
    clientes.Add(novoCliente);
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();


}
void ListarClientes()
{
    if (clientes.Count == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
        return;
    }
    else
    {
        foreach (Cadastro cliente in clientes)
        {
            cliente.ExibirCadastro();

        }
    }
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();



}

void CadastroProdutos()
{
    Console.WriteLine("Qual nome do Produto: ");
    string Nome = Console.ReadLine()!;
    Console.WriteLine("Qual o preço do Produto: ");
    float Preco = float.Parse(Console.ReadLine()!);
    Console.WriteLine("Qual a quantidade do Produto: ");
    int Quantidade = int.Parse(Console.ReadLine()!);
    Console.WriteLine(" ");
    Produtos novoProduto = new Produtos(Nome, Preco, Quantidade);
    produtos.Add(novoProduto);
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();
}
void ListarProdutos()
{
    if (produtos.Count == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado.");
        return;
    }
    else
    {
        foreach (Produtos produto in produtos)
        {
            produto.ExibirProduto();
        }
    }
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();
}



