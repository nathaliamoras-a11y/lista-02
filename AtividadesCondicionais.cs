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
}