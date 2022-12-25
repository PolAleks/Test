namespace Color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите название цвета на английском языке: ");
                string nameColor = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(nameColor))
                {
                    //nameColor = nameColor.Substring(0, 1).ToUpper() + nameColor.Substring(1).ToLower();
                    bool isConsoleColor = Enum.IsDefined(typeof(ConsoleColor), nameColor);

                    if (isConsoleColor)
                    {
                        ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), nameColor, false);
                        Console.ForegroundColor = color;
                        Console.WriteLine($"Выбранный вами цвет: {color}");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.WriteLine("Такого цвета нет");
                    }
                }
                else
                {
                    Console.WriteLine("Вы не ввели наименовани цвета");
                }
                
            }while(true);
        }
    }
}