using MulticastDelegate.Services;

BinaryNumericOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;

double a = 10;
double b = 12;

op(a, b);

internal delegate void BinaryNumericOperation(double n1, double n2);