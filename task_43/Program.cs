// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int COFF = 0;
const int CONST = 1;

const int X = 0;
const int Y = 1;

const int L1 = 1;
const int L2 = 2;

double[] line1 = InpytLine(L1);
double[] line2 = InpytLine(L2);

if (Proverka(line1, line2))
{
    double[] coord = FindCoord(line1, line2);
    Console.WriteLine($"Точка пересечения имеет координаты (|{coord[X]}| , |{coord[Y]}|)");
}
//------------------------------------------------

// Ввод числа
double Inpute(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввод значений по прямой
double[] InpytLine(int numb)
{
    double[] Line = new double[2];
    Line[COFF] = Inpute($"Введите коэффициент для {numb} прямой");
    Line[CONST] = Inpute($"Введите коэффициент для {numb} прямой");
    return Line;
}

// Поиск координат
double[] FindCoord(double[] line1, double[] line2)
{
    double[] coord = new double[2];
    coord[X] = line1[CONST] - line2[CONST] / (line2[COFF] - line1[COFF]);
    coord[Y] = line1[CONST] * coord[X] + line1[CONST];
    return coord;
}

bool Proverka(double[] line1, double[] line2)
{
    if (line1[COFF] == line2[COFF])
    {
        if(line1[CONST] == line2[CONST])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}