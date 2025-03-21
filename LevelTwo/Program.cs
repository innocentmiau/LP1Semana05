using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string imagePath = args.Length > 0 ? args[0] : "tux.jpg";
            CanvasImage image = new CanvasImage(imagePath);
            int width = args.Length > 1 ? int.Parse(args[1]) : 24;
            image.MaxWidth(width);
            
            AnsiConsole.Write(image);
        }
    }
}
