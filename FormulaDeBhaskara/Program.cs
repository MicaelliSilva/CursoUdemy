int a = 2;
int b = 6;
int c = 4;

double delta = b * b - 4 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);