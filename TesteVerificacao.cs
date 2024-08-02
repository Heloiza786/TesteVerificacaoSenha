using System;

class VerificacaoTurmasAlunos
{
    private int quantidadePturmas = 30;
    private string nome = "";
    private string sobrenome = "";
    private string cpf = "";
    private string idade = "";
    private string email = "";
    public VerificacaoTurmasAlunos(string nome, string sobrenome, string cpf, string idade, string email)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.cpf = cpf;
        this.idade = idade;
        this.email = email;
    }
    public string VerificarCampos()
    {
        if (!string.IsNullOrEmpty(nome) &&
            !string.IsNullOrEmpty(sobrenome) &&
            !string.IsNullOrEmpty(cpf) &&
            !string.IsNullOrEmpty(idade) &&
            !string.IsNullOrEmpty(email))
        {
            return "Os campos foram preenchidos com sucesso!";
        }
        else
        {
            return "Os campos não foram preenchidos corretamente.";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Digite o sobrenome:");
        string sobrenome = Console.ReadLine();
        
        Console.WriteLine("Digite o CPF:");
        string cpf = Console.ReadLine();
        
        Console.WriteLine("Digite a idade:");
        string idade = Console.ReadLine();
        
        Console.WriteLine("Digite o email:");
        string email = Console.ReadLine();
        

        VerificacaoTurmasAlunos verificacao = new VerificacaoTurmasAlunos(nome, sobrenome, cpf, idade, email);
        string resultado = verificacao.VerificarCampos();
        Console.WriteLine(resultado);
    }
}
