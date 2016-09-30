using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectanglePoint();
            Rectangle r2 = ReadRectanglePoint();
            Console.WriteLine(r1.IsInside(r2) ? "Inside" :
              "Not inside");
        }
        private static Rectangle ReadRectanglePoint()
        {
            var tookens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rect = new Rectangle()
            {
                Left = tookens[0],
                Top = tookens[1],
                Width = tookens[2],
                Height = tookens[3]
            };
            return rect;
        }

    }
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        
        int CalcArea()
        {
            return Width * Height;
        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
               (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
