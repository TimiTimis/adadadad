using System;

class Program
{
    static void Main()
    {
        // 1. Создаем объект класса Car
        Car car = new Car();
        // 2. Задаем значения полям
        car.marka = "Жигули";
        car.nomer = "Т144ТО";
        car.probeg = 10350;
        // 3. Выводим данные на экран
        car.Show();
        // 4. Рассчитываем среднегодовой пробег при возрасте 2 года
        float sredniy = car.SredProbeg(2);
        Console.WriteLine("Среднегодовой пробег (возраст 2 года): " + sredniy);
        Console.ReadKey();
    }
}
class Car
{
    // Открытые поля
    public string marka;   // марка автомобиля
    public string nomer;   // гос. номер
    public int probeg;     // пробег
    // Метод - показать данные об автомобиле
    public void Show()
    {
        Console.WriteLine("Марка: " + marka);
        Console.WriteLine("Гос. номер: " + nomer);
        Console.WriteLine("Пробег: " + probeg);
    }
    // Метод - расчет среднего пробега для заданного возраста
    public float SredProbeg(int vozrast)
    {
        return (float)probeg / vozrast;
    }
}