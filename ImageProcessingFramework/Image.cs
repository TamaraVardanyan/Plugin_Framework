using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingFramework
{
    public class Image
    {
        public string Name { get; }
        public List<IImageEffect> Effects { get; } = new List<IImageEffect>();

        public Image(string name)
        {
            Name = name;
        }

        public void ApplyEffects()
        {
            Console.WriteLine($"Processing '{Name}'...");
            foreach (var effect in Effects)
            {
                effect.Apply(this);
            }
            Console.WriteLine($"Processing of '{Name}' completed.\n");
        }
    }
}
