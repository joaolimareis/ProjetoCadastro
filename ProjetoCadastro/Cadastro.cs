public class Cadastro
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Cadastro(string nome, string email, string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
    public void ExibirCadastro()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Telefone: {Telefone}");
    }
}