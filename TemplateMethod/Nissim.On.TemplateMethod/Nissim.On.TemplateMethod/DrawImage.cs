﻿using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Nissim.On.TemplateMethod
{
    class DrawImage
    {
        public static void DrawImageInConsole(string p_image)
        {
            Image Picture = Image.FromFile(p_image);

            Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
            int FrameCount = Picture.GetFrameCount(Dimension);
            int Left = Console.WindowLeft, Top = Console.WindowTop;
            char[] Chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
            Picture.SelectActiveFrame(Dimension, 0x0);
            for (int i = 0x0; i < Picture.Height; i++)
            {
                for (int x = 0x0; x < Picture.Width; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x, i);
                    int Gray = (Color.R + Color.G + Color.B) / 0x3;
                    int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;
                    Console.Write(Chars[Index]);
                }
                Console.Write('\n');
            }
        }

        public static void DrawSpace(int p_rows, int p_cols)
        {
            for (var i = 0; i < p_rows; i++)
            {
                for (var j = 0; j < p_cols; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
