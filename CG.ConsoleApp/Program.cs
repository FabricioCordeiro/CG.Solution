namespace CG.ConsoleApp
{
    internal class Program
    {
        public static int[,] Dimension { get; set; } = new int[10, 10];
        static void Main(string[] args)
        {
            PlotReta((5, 3), 5);
            ViewImage();
        }

        static void ViewImage()
        {
            for (int y = 0; y < Dimension.GetLength(0); y++)
            {
                for (int x = 0; x < Dimension.GetLength(1); x++)
                {
                    if (Dimension[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{Dimension[y, x]} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write($"{Dimension[y, x]} ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void PlotReta((int AxisX, int AxisY) initialPoint, int lenght)
        {
            if (lenght <= Dimension.GetLength(0))
            {
                lenght += initialPoint.AxisY - 1;
                initialPoint.AxisX--;
                initialPoint.AxisY--;

                for (int AxisY = initialPoint.AxisY; AxisY < lenght;)
                {
                    Dimension[AxisY, initialPoint.AxisX] = 1;
                    AxisY++;
                }
            }
            else
            {
                throw new ArgumentException("Estouro do eixo das ordenadas");
            }
        }
    }
}