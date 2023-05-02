// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int IndexOfEquation(string msg){
    Console.Write($"Введите коэффициент {msg} =");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintEquation(double k, double b){
    Console.WriteLine($"y={k.ToString("F0")}x+{b.ToString("F0")}");
}

double k1 = IndexOfEquation("k1");
double b1 = IndexOfEquation("b1");
double k2 = IndexOfEquation("k2");
double b2 = IndexOfEquation("b2");

PrintEquation(k1,b1);
PrintEquation(k2,b2);

double x = -(b2-b1)/(k2-k1);
double y = k1*x+b1;

Console.WriteLine($"Точка пересечения: ({x.ToString("F2")}; {y.ToString("F2")})");
