//Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
//2. Exibir as notas e calcular a média.
//3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).

int[] notas = new int[5];
int soma = 0;


for (int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.WriteLine("Digite a nota do aluno: ");
        notas[i] = int.Parse(Console.ReadLine());

        if (notas[i] < 0 || notas[i] > 10)
        {
            throw new ArgumentOutOfRangeException("Digite uma nota entre 0 e 10");
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Digite apenas numeros inteiros");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.ParamName);
    }
}

Console.WriteLine("Notas do aluno:");

foreach (int item in notas)
{
    Console.Write(item + " ");
    soma = item + soma;
}

Console.WriteLine("");

Console.WriteLine($"Média: {soma / notas.Length}");

if (soma / notas.Length >= 7)
{
    Console.WriteLine("O aluno foi APROVADO!");
}
else
{
    Console.WriteLine("O aluno foi reprovado");
}

