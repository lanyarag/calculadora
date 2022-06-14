double resultado = 0;
string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario != "0")
{
    switch (opcaoUsuario)
    {
        case "1":
            Console.WriteLine("Você digitou 1 - Somar. Qual valor deseja somar?");
            try
            {
                double operando = double.Parse(Console.ReadLine());
                Console.WriteLine(somarValor(operando));
            }
            catch (Exception erro)
            {
                Console.WriteLine(Environment.NewLine + "CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
            }
            break;
        case "2":
            Console.WriteLine("Você digitou 2 - Subtrair. Qual valor deseja subtrair?");
            try
            {
                double operando = double.Parse(Console.ReadLine());
                Console.WriteLine(subtrairValor(operando));
            }
            catch (Exception erro)
            {
                Console.WriteLine(Environment.NewLine + "CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
            }
            break;
        case "3":
            Console.WriteLine("Você digitou 3 - Multiplicar. Qual valor deseja multiplicar?");
            try
            {
                double operando = double.Parse(Console.ReadLine());
                Console.WriteLine(multiplicarValor(operando));
            }
            catch (Exception erro)
            {
                Console.WriteLine(Environment.NewLine + "CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
            }
            break;
        case "4":
            Console.WriteLine("Você digitou 4 - Dividir. Qual valor deseja dividir?");
            try
            {
                double operando = double.Parse(Console.ReadLine());
                Console.WriteLine(dividirValor(operando));
            }
            catch (Exception erro)
            {
                Console.WriteLine(Environment.NewLine + "CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
            }
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

double dividirValor2(double valor)
{
    try
    {
        if (valor == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            return resultado / valor;
        }
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine("CodError001 - Divisão por 0 não é possível.");
        Console.WriteLine(exception.GetType());
        Console.WriteLine("Localização");
    }
    return 0;
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
    definirResultadoDaUltimaOperacaoMatematica(zerar);
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