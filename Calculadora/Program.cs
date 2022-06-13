double resultado = 0;
string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario != "0")
{
    switch (opcaoUsuario)
    {
        case "1":
            Console.WriteLine("Você digitou 1 - Somar. Qual valor deseja somar?");
            //somarValor(double.Parse(Console.ReadLine()));
            Console.WriteLine(somarValor(double.Parse(Console.ReadLine())));
            break;
        case "2":
            Console.WriteLine("Você digitou 2 - Subtrair. Qual valor deseja subtrair?");
            Console.WriteLine(subtrairValor(double.Parse(Console.ReadLine())));
            break;
        case "3":
            Console.WriteLine("Você digitou 3 - Multiplicar. Qual valor deseja multiplicar?");
            Console.WriteLine(multiplicarValor(double.Parse(Console.ReadLine())));
            break;
        case "4":
            Console.WriteLine("Você digitou 4 - Dividir. Qual valor deseja dividir?");
            Console.WriteLine(dividirValor(double.Parse(Console.ReadLine())));
            break;
        case "5":
            Console.WriteLine("Você digitou 5 - Zerar calculadora.");
            zerarResultado();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }


    opcaoUsuario = ObterOpcaoUsuario();
}

Console.WriteLine("Obrigado por utilizar nossos serviços");

double somarValor(double valor)
{

    double resultadoSoma = pegarResultadoDaUltimaOperacaoMatematica() + valor;
    definirResultadoDaUltimaOperacaoMatematica(resultadoSoma);
    return resultadoSoma;
}



double subtrairValor(double valor)
{
    double resultadoSubtração = pegarResultadoDaUltimaOperacaoMatematica() - valor;
    definirResultadoDaUltimaOperacaoMatematica(resultadoSubtração);
    return resultadoSubtração;
}

double dividirValor(double valor)
{


    try
    {
        double resultadoDivisao = pegarResultadoDaUltimaOperacaoMatematica() / valor;
        definirResultadoDaUltimaOperacaoMatematica(resultadoDivisao);
        return resultadoDivisao;
        throw new Exception("Valor inserido é inválido.");
    }

    catch (Exception erro) when (valor == 0 || resultado == 0)
    {
        Console.WriteLine("CodError001 - Divisão por 0 não é possível.");
        Console.WriteLine(erro.GetType());
        return valor;
        Console.WriteLine();
    }

}

double multiplicarValor(double valor)
{

    double resultadoMultiplicação = pegarResultadoDaUltimaOperacaoMatematica() * valor;
    definirResultadoDaUltimaOperacaoMatematica(resultadoMultiplicação);
    return resultadoMultiplicação;

}

double zerarResultado()
{
    double zerar = resultado * 0;
    return zerar;
}

double pegarResultadoDaUltimaOperacaoMatematica()
{
    return resultado;
}

void definirResultadoDaUltimaOperacaoMatematica(double resultadoOperacao)
{
    resultado = resultadoOperacao;
}


string ObterOpcaoUsuario()
{
    Console.WriteLine("Escolha qual operação deseja realizar: ");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Zerar calculadora");
    Console.WriteLine("0 - Para sair da calculadora");

    string opcaoUsuario = Console.ReadLine();

    return opcaoUsuario;
}