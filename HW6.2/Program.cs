double СoordinateInput(string massage)
{
    Console.WriteLine(massage);
    var Сoordinate = Convert.ToDouble(Console.ReadLine());
    return Сoordinate;
}


double k1 = СoordinateInput("Введите координату k1");
double k2 = СoordinateInput("Введите координату k2");
double b1 = СoordinateInput("Введите координату b1");
double b2 = СoordinateInput("Введите координату b2");
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");