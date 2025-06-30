 
      class Calculatrice
{
     static void Main(string[] args)
        {
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

        static double DoOperation(double num1, double num2, string op)
        {
            double resultat = double.NaN;

            switch (op)
            {
                case "a":
                    resultat = num1 + num2;
                    Console.WriteLine("Résultat =");
                    break;
                case "s":
                    resultat = num1 - num2;
                    Console.WriteLine("Résultat =");
                    break;
                case "m":
                    resultat = num1 * num2;
                    Console.WriteLine("Résultat =");
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        resultat = num1 / num2;
                        Console.WriteLine("Résultat =");
                    }
                    break;
            }
            return resultat;
        }

    }
}



/*double num1 = 0; 
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
Console.WriteLine("\d - Division");
Console.WriteLine("Votre choix ?");*/