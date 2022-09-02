class Program
{

    static void Main(string[] args)
    {
        string Nome;  // Variavel de Texto Entrada

        Console.Clear();  // Limpa Tela
        Console.WriteLine("Digite seu Nome: ");  // Interface 1
        Console.SetCursorPosition(17, 0); // Posição 1
        Nome = Console.ReadLine();  // Entrada
        Console.WriteLine("Bem Vindo: " + Nome);  // Saída 1
        Console.ReadLine();
    }
}
