
string Nome;  // Variavel Texto Entrada
int Idade;  // Variavel Inteira Entrada
string Curso;  // Variavel Texto Entrada

Console.Clear();  // Limpa Tela
Console.WriteLine("Digite seu Nome: ");  // Interface 1
Console.SetCursorPosition(17, 0);  // Posição 1    
Nome = Console.ReadLine();  // Entrada 1

Console.WriteLine("Digite sua Idade: ");  // Interface 2
Console.SetCursorPosition(19, 1);  // Posição 2
Idade = int.Parse(Console.ReadLine());  //  Entrada 2  

Console.WriteLine("Digite seu Curso: ");  // Interface 3
Console.SetCursorPosition(18, 2);  // Posição 3
Curso = Console.ReadLine();  // Entrada 3

Console.WriteLine("Meu Nome: " + Nome + " - Minha Idade: " + Idade + " - Meu Curso: " + Curso);  // Saída 1
Console.ReadLine();
