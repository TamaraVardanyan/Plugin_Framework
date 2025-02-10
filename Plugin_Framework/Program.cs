using ImageProcessingFramework;
using ImageProcessingFramework.ImageEffect;
using Image = ImageProcessingFramework.Image;

class Program
{
    static void Main()
    {
        PluginManager.RegisterPlugin("Resize", typeof(ResizeEffect));
        PluginManager.RegisterPlugin("Blur", typeof(BlurEffect));
        PluginManager.RegisterPlugin("Rotate", typeof(RotateEffect));

        Image img = new Image("Image");
        img.Effects.Add(PluginManager.CreatePlugin("Resize", 100));
        img.Effects.Add(PluginManager.CreatePlugin("Blur", 2));
        img.Effects.Add(PluginManager.CreatePlugin("Rotate", 90));

        
        img.ApplyEffects();
        
    }
}
