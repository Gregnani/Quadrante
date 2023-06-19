Console.Clear();

double cordenadaX;
double cordenadaY;
string local;

Console.BackgroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("---Quadrante Carteziano---\n");

Console.ResetColor();

Console.WriteLine("Entre com o ponto desejado\n");

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Cordenada X:");
cordenadaX = Convert.ToDouble(Console.ReadLine())!;

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.Write("Cordenada Y:");
cordenadaY = Convert.ToDouble(Console.ReadLine())!;

Console.ResetColor();

if(cordenadaX == 0 && cordenadaY == 0 ) local = "a origem";
else if (cordenadaX == 0) local = "o eixo das ordenadas";
else if (cordenadaY == 0) local = "o eixo das abscissas";
 
     {
    if (cordenadaX > 0)
        local = "quadrante 1";
    else
        local = "quadrante 2";
    }

    {
    if (cordenadaX < 0)
        local = "quadrante 3";
    else
        local = "quadrante 4";
    }

    Console.WriteLine($"\nO ponto ({cordenadaX}, {cordenadaY}) fica no {local}.\n");

