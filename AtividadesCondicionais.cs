public class AtividadesCondicionais
{
    public static void Atividade01()
    {
        Console.WriteLine("Informe a idade do visitante:");
        int idade = int.Parse(Console.ReadLine()!);

        if (idade >= 16)
        {
            Console.WriteLine("Entrada liberada.");
        }
        else
        {
            Console.WriteLine("Entrada permitida somente com responsável.");
        }
    }
    public static void Atividade02()
    {
        Console.WriteLine("Informe a nota final:");
        double nota = double.Parse(Console.ReadLine()!);

        if (nota >= 7)
        {
            Console.WriteLine("Estudante aprovado.");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Estudante em recuperação.");
        }
        else
        {
            Console.WriteLine("Estudante reprovado.");
        }
    }
    public static void Atividade03()
    {
        Console.WriteLine("Informe a temperatura atual:");
        double temperatura = double.Parse(Console.ReadLine()!);

        if (temperatura < 18)
        {
            Console.WriteLine("Ambiente frio.");
        }
        else if (temperatura <= 26)
        {
            Console.WriteLine("Ambiente confortável.");
        }
        else
        {
            Console.WriteLine("Ambiente quente.");
        }
    }
    public static void Atividade04()
    {
        Console.WriteLine("Informe o valor total da compra:");
        double valorOriginal = double.Parse(Console.ReadLine()!);

        double desconto = 0;

        if (valorOriginal >= 200)
        {
            desconto = valorOriginal * 0.10;
        }

        double valorFinal = valorOriginal - desconto;

        Console.WriteLine("Valor original: R$ " + valorOriginal);
        Console.WriteLine("Desconto aplicado: R$ " + desconto);
        Console.WriteLine("Valor final: R$ " + valorFinal);

    }
    public static void Atividade05()
    {
        Console.WriteLine("Informe a quantidade de tarefas concluídas:");
        int tarefas = int.Parse(Console.ReadLine()!);

        if (tarefas >= 50)
        {
            Console.WriteLine("Meta atingida.");
            Console.WriteLine("Tarefas concluídas: " + tarefas);
        }
        else
        {
            int faltaram = 50 - tarefas;

            Console.WriteLine("Meta não atingida.");
            Console.WriteLine("Faltaram " + faltaram + " tarefas.");
        }
    }
    public static void Atividade06()
    {
        Console.WriteLine("Informe a idade:");
        int idade = int.Parse(Console.ReadLine()!);

        if (idade <= 11)
        {
            Console.WriteLine("Faixa etária: criança.");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Faixa etária: adolescente.");
        }
        else if (idade <= 59)
        {
            Console.WriteLine("Faixa etária: adulto.");
        }
        else
        {
            Console.WriteLine("Faixa etária: idoso.");
        }
    }
    public static void Atividade07()
    {
        Console.WriteLine("Informe o primeiro número:");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o segundo número:");
        int num2 = int.Parse(Console.ReadLine()!);

        if (num1 > num2)
        {
            Console.WriteLine("O primeiro número é maior.");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("O segundo número é maior.");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }

    }
    public static void Atividade08()
    {
        Console.WriteLine("Informe a primeira pontuação:");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe a segunda pontuação:");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe a terceira pontuação:");
        int num3 = int.Parse(Console.ReadLine()!);

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("As três pontuações são iguais.");
        }
        else if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("Maior pontuação: " + num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("Maior pontuação: " + num2);
        }
        else
        {
            Console.WriteLine("Maior pontuação: " + num3);
        }

    }
    public static void Atividade09()
    {
        Console.WriteLine("Informe um número inteiro:");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número informado é par.");
        }
        else
        {
            Console.WriteLine("O número informado é ímpar.");
        }

    }
    public static void Atividade010()
    {
        Console.WriteLine("Informe a idade do passageiro:");
        int idade = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o valor normal da passagem:");
        double valor = double.Parse(Console.ReadLine()!);

        double valorPagar;

        if (idade <= 5)
        {
            valorPagar = 0;
        }
        else if (idade >= 60)
        {
            valorPagar = valor / 2;
        }
        else
        {
            valorPagar = valor;
        }

        Console.WriteLine("Valor normal da passagem: R$ " + valor);
        Console.WriteLine("Valor a pagar: R$ " + valorPagar);
    }
}