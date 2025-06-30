/*static void Main(string[] args)
{
    Console.WriteLine("Bienvenue dans votre Calculatrice C#\r");
    Console.WriteLine("-----------------------------\n");

}*/

double num1 = 0; 
double num2 = 0;

Console.WriteLine("Bienvenue dans votre Calculatrice C#\r");
Console.WriteLine("-----------------------------\n");
Console.WriteLine("Entrez votre premier nombre, puis appuyez sur Entrée");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez votre deuxième nombre, puis appuyez sur Entrée");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sélectionnez une option dans la liste suivante :");
Console.WriteLine("\ta - Addition");
Console.WriteLine("\ts - Soustraction");
Console.WriteLine("\tm - Multiplication");
Console.WriteLine("\td - Division");
Console.WriteLine("Votre choix ?");