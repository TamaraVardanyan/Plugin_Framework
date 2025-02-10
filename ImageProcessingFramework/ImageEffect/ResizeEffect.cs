using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingFramework.ImageEffect
{
    public class ResizeEffect : IImageEffect
    {
        public int Width { get; }

        public ResizeEffect(int width)
        {
            Width = width;
        }

        public void Apply(Image image)
        {
            Console.WriteLine($"Resizing '{image.Name}' to width {Width}px.");
        }
    }
}
