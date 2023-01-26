abstract class Figure
    {
        public abstract void FindSquare();
        public void GetQuantity(double result)
        {
            Console.Write("Вычисляю площадь... Готово! ");
            Console.WriteLine("{0:0.00}", result);
            Console.WriteLine();
        }
    }