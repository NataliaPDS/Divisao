internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("DIVISÃO");

            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine($"\nResultado = {result}");

        }
        catch (DivideByZeroException ex)//10 / 0 = está mensagem
        {
            Console.WriteLine($"\nAlgo de errado não está certo! {ex.Message}");
        } 
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"\nConversão do string para letra não é permitida{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Obrigado");
                
        }
    }
}