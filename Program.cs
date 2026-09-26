Console.WriteLine("---Queda-livre---\n");
Console.Write("Entre com Altura de Queda (em metros):");

double h = Convert.ToDouble(Console.ReadLine());
const double g = 9.80665;
 double t = Math.Sqrt  ((2 * h) / g);
 double v = Math.Sqrt  ( 2 * h * g );


Console.WriteLine($" Tempo de Queda...:{t:N2}s");
Console.WriteLine($" Velocidade Final...:{v:N2}m/s");


