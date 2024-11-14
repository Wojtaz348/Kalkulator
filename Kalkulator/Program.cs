using System;

class Kalkulator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nKalkulator - wybierz operację:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Silnia");
            Console.WriteLine("6. Potęgowanie");
            Console.WriteLine("7. Pierwiastkowanie");
            Console.WriteLine("8. Wyrażenie z kolejnością działań");
            Console.WriteLine("9. Wyjście");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    Factorial();
                    break;
                case "6":
                    Power();
                    break;
                case "7":
                    SquareRoot();
                    break;
                case "8":
                    EvaluateExpression();
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór!");
                    break;
            }
        }
    }

    static void Addition()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Wynik: {a + b}");
    }

    static void Subtraction()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Wynik: {a - b}");
    }

    static void Multiplication()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Wynik: {a * b}");
    }

    static void Division()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (b != 0)
            Console.WriteLine($"Wynik: {a / b}");
        else
            Console.WriteLine("Nie można dzielić przez zero!");
    }

    static void Factorial()
    {
        Console.Write("Podaj liczbę: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Silnia nie jest zdefiniowana dla liczb ujemnych!");
            return;
        }
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        Console.WriteLine($"Silnia z {n} wynosi: {result}");
    }

    static void Power()
    {
        Console.Write("Podaj podstawę: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj wykładnik: ");
        double exponent = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Wynik: {Math.Pow(baseNum, exponent)}");
    }

    static void SquareRoot()
    {
        Console.Write("Podaj liczbę: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number >= 0)
            Console.WriteLine($"Pierwiastek z {number} wynosi: {Math.Sqrt(number)}");
        else
            Console.WriteLine("Nie można obliczyć pierwiastka z liczby ujemnej!");
    }

    static void EvaluateExpression()
    {
        Console.WriteLine("Podaj wyrażenie (np. 2 + 3 * 4): ");
        string expression = Console.ReadLine();
        try
        {
            // Używamy System.Data.DataTable do bezpiecznej ewaluacji wyrażenia
            System.Data.DataTable table = new System.Data.DataTable();
            var result = table.Compute(expression, "");
            Console.WriteLine($"Wynik: {result}");
        }
        catch (Exception)
        {
            Console.WriteLine("Nieprawidłowe wyrażenie!");
        }
    }
}