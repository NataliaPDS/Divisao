try
{
    Console.WriteLine("DIVISÃO");

    Console.WriteLine("Digite o primeiro número: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine($"\nResultado = {result}");

}catch(Exception ex)//10 / 0 = está mensagem
{
     Console.WriteLine($"\nAlgo de errado não está certo! {ex.Message}");
}