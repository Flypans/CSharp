using System;

class EnumTest
{
    enum Animal { Mouse, Tiger, Cow, Dog}
    static void Main()
    {
        Animal HomePet = Animal.Dog;
        Console.WriteLine(HomePet);
        Console.WriteLine((int)HomePet);

        Console.WriteLine((int)Animal.Tiger);
        Console.WriteLine(nameof(Animal.Tiger));


        Console.ForegroundColor = ConsoleColor.Blue;
        //Console.WriteLine("Blue");
        //Console.ResetColor();

        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.BackgroundColor = ConsoleColor.White;
        //Console.WriteLine($"Green & {nameof(ConsoleColor.White)}");
        //Console.ResetColor();

        switch (Console.ForegroundColor)
        {
            case ConsoleColor.Black:
                break;
            case ConsoleColor.DarkBlue:
                break;
            case ConsoleColor.DarkGreen:
                break;
            case ConsoleColor.DarkCyan:
                break;
            case ConsoleColor.DarkRed:
                break;
            case ConsoleColor.DarkMagenta:
                break;
            case ConsoleColor.DarkYellow:
                break;
            case ConsoleColor.Gray:
                break;
            case ConsoleColor.DarkGray:
                break;
            case ConsoleColor.Blue:
                Console.WriteLine("Bingo Blue");
                break;
            case ConsoleColor.Green:
                Console.WriteLine("Bingo Green");
                break;
            case ConsoleColor.Cyan:
                break;
            case ConsoleColor.Red:
                break;
            case ConsoleColor.Magenta:
                break;
            case ConsoleColor.Yellow:
                break;
            case ConsoleColor.White:
                Console.WriteLine("Bingo White");
                break;
            default:
                break;
        }

    }
}