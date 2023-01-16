double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double area = CalculateRectangleArea(width, height);
Console.WriteLine(area);
static double CalculateRectangleArea(double width, double heigth)
{
    return width * heigth;
}