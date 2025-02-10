using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingFramework
{
    public interface IImageEffect
    {
        void Apply(Image image);
    }

}
