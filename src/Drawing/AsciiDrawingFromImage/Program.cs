using System;
using System.Drawing;

namespace AsciiDrawingFromImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ascii = new string[] { "#","@","%","=","+","*",":","-","."," " };
            Console.Write("Введите путь к файлу в формате C:/Users/some.jpg: ");
            string imgFromFile = Console.ReadLine();
            Image img = Bitmap.FromFile(imgFromFile);
            Bitmap bitmap = new Bitmap(img);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = bitmap.GetPixel(i, x);
                    int grayColor = (color.R + color.G + color.B) / 3;
                    int index = grayColor * 9 / 255;
                    Console.Write(ascii[index]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
