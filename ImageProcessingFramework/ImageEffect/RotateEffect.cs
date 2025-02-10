using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingFramework.ImageEffect
{
    public class RotateEffect : IImageEffect
    {
        public int Angle { get; }

        public RotateEffect(int angle)
        {
            Angle = angle;
        }

        public void Apply(Image image)
        {
            Console.WriteLine($"Rotating '{image.Name}' by {Angle} degrees.");
        }
    }
}
