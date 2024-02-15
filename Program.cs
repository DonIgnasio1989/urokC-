// See https://aka.ms/new-console-template for more information

using System;

namespace DensityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Параметры нефтепродукта (можно ввести извне или использовать значения по умолчанию)
            double densityAtStandardTemp = 850; // Плотность по паспорту качества при стандартной температуре
            double tempCoefficient = 0.7;       // Коэффициент изменения плотности относительно температуры
            double naturalLossCoefficient = 0.0005; // Коэффициент естественной убыли (примерный)

            // Ввод данных пользователем
            Console.WriteLine("Введите температуру нефтепродукта (в градусах Цельсия):");
            double temperature = Convert.ToDouble(Console.ReadLine());

            // Расчет плотности по заданной температуре
            double density = densityAtStandardTemp - tempCoefficient * (temperature - 20);

            // Расчет массы естественной убыли
            double naturalLoss = naturalLossCoefficient * density;

            // Вывод результата
            Console.WriteLine($"При температуре {temperature}°C плотность нефтепродукта составляет {density} кг/м³");
            Console.WriteLine($"Масса естественной убыли: {naturalLoss} кг/м³");
        }
    }
}
