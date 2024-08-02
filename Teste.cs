unisng System;

 class Program{
    static string VerificacaoSenha(string senha){
       int  tamanho = 8;
       bool LetraMaiuscula = false;
       bool LetraMinuscula = false;
       bool ContemNumeros = false;
       bool ConteCaracteresEspeciais = false;
    }
        if(senha.Length < tamanho length)
            return ("Verifique sua senha e tente novamente")
        LetraMaiuscula = senha.Any(char.IsUpper);
        LetraMinuscula = senha.Any(char.IsLowe);
        string[] sequenciasComuns = {"123456","abcdef"}
        if (sequenciasComuns.Any(s => senha.Containes(s))) 
            return ("Sua senha contem uma sequencia comum, Favor tente novamente.")
                
        ContemCaracteresEspeciais = senha.Any(char.IsDigit);
        ContemCaracteresEspeciais = senha.Any(c => !char.IsLetterOrDigit(c));

        if (  LetraMaiuscula &&  LetraMaiuscula && ContemNumeros && ConteCaracteresEspeciais)
            return "Sua senha atende aos requisitos de seguranca. Parabens!";
        else
            return "Sua senha nao atende aos requisitos de seguranca.";
        }

     static void Main(string[args])
    {
        string senha = Console.ReadLine().Trim();
        string resultado = VerificarForcaSenha(senha);
        Console.WriteLine(resultado);
    }