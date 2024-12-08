using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public class Coins
    {
 

    
    
        public static void CountCoins(Bitmap bmp, ref Label countLabel, ref Label valueLabel)
        {
            int count = 0; 
            float value = 0; 

            int height = bmp.Height;
            int width = bmp.Width;

            bool[,] visited = new bool[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    if (!visited[i, j] && IsBlack(pixel))
                    {
                        count++;
                        value += Classify(BFS(bmp, visited, j, i), ref count);
                    }
                }

            countLabel.Text = count.ToString();
            valueLabel.Text = value.ToString("F2");
        }

  
        private static float Classify(int pixelCount, ref int count)
        {

            if (pixelCount >= 18000) return 5f;
            if (pixelCount >= 15000) return 1f;
            if (pixelCount >= 11000) return .25f;
            if (pixelCount >= 8000) return .1f;
            if (pixelCount >= 6500) return .05f;
          
            count--;
            return 0;
        }

     
        private static int BFS(Bitmap bmp, bool[,] visited, int startX, int startY)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            int pixelCount = 0;

            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(startX, startY));

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();
                int x = current.X, y = current.Y;

                if (x < 0 || x >= width || y < 0 || y >= height || visited[y, x] || !IsBlack(bmp.GetPixel(x, y)))
                {
                    continue;
                }

                pixelCount++;
                visited[y, x] = true;

                queue.Enqueue(new Point(x - 1, y));
                queue.Enqueue(new Point(x + 1, y));
                queue.Enqueue(new Point(x, y - 1));
                queue.Enqueue(new Point(x, y + 1));
            }

            return pixelCount;
        }

        private static bool IsBlack(Color pixel) => pixel.R == 0 && pixel.G == 0 && pixel.B == 0;
    }
}
