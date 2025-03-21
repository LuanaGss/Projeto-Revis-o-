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
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Digite apenas numeros inteiros");
        break;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.ParamName);
        break;
    }
    if (notas[i] >= 0 && notas[i] <= 10)
    {
        throw new ArgumentOutOfRangeException("Digite uma nota entre 0 e 10");
    }
}

foreach (int item in notas)
{
    Console.WriteLine(item);
    soma = item + soma;
}

if (soma / notas.Length >= 7)
{
    Console.WriteLine("Aluno aprovado");
}
else
{
    Console.WriteLine("Aluno reprovado");
}
