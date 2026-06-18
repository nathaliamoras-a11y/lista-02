public class AtividadesRepeticao
{
    public static void Atividade11()
    {
        Console.WriteLine("Informe o número final da contagem:");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Atividade12()
    {
        Console.WriteLine("Informe o número inicial da contagem regressiva:");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");
    }
    public static void Atividade13()
    {
        Console.WriteLine("Informe o número da tabuada:");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
    public static void Atividade14()
    {
        double soma = 0;

        Console.WriteLine("Informe o primeiro valor:");
        soma += double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o segundo valor:");
        soma += double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o terceiro valor:");
        soma += double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o quarto valor:");
        soma += double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o quinto valor:");
        soma += double.Parse(Console.ReadLine()!);

        double media = soma / 5;

        Console.WriteLine("Soma dos valores: " + soma);
        Console.WriteLine("Média dos valores: " + media);
    }

    public static void Atividade15()
    {
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Informe um número:");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero > 0)
            {
                positivos++;
            }
            else if (numero < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        Console.WriteLine("Quantidade de positivos: " + positivos);
        Console.WriteLine("Quantidade de negativos: " + negativos);
        Console.WriteLine("Quantidade de zeros: " + zeros);
    }

    public static void Atividade16()
    {
        int senha;

        do
        {
            Console.WriteLine("Informe a senha:");
            senha = int.Parse(Console.ReadLine()!);

            if (senha != 1234)
            {
                Console.WriteLine("Senha incorreta. Tente novamente.");
            }

        } while (senha != 1234);

        Console.WriteLine("Acesso permitido.");
    }

    public static void Atividade17()
    {
        double nota;

        do
        {
            Console.WriteLine("Informe uma nota de 0 a 10:");
            nota = double.Parse(Console.ReadLine()!);

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida. Informe novamente.");
            }

        } while (nota < 0 || nota > 10);

        Console.WriteLine("Nota registrada: " + nota);
    }

    public static void Atividade18()
    {
        Console.WriteLine("Informe a quantidade de clientes atendidos:");
        int quantidade = int.Parse(Console.ReadLine()!);

        int total = 0;

        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine("Informe o tempo do atendimento:");
            int tempo = int.Parse(Console.ReadLine()!);

            total += tempo;
        }

        double media = (double)total / quantidade;

        Console.WriteLine("Tempo total de atendimento: " + total + " minutos");
        Console.WriteLine("Tempo médio por cliente: " + media + " minutos");
    }
}