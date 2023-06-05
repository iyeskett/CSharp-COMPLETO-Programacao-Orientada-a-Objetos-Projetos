using Delegates.Services;

BinaryNumericOperation op = CalculationService.Max;

double a = 10;
double b = 12;

double result = op(a, b);
Console.WriteLine(result);

internal delegate double BinaryNumericOperation(double n1, double n2);