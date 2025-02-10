using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingFramework.ImageEffect
{
    public class BlurEffect : IImageEffect
    {
        public int BlurSize { get; }

        public BlurEffect(int blurSize)
        {
            BlurSize = blurSize;
        }

        public void Apply(Image image)
        {
            Console.WriteLine($"Applying blur of {BlurSize}px to '{image.Name}'.");
        }
    }
}
