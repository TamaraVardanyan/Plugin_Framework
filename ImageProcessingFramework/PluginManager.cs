using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingFramework
{
    public static class PluginManager
    {
        private static readonly Dictionary<string, Type> plugins = new();

        public static void RegisterPlugin(string name, Type type)
        {
            if (typeof(IImageEffect).IsAssignableFrom(type))
            {
                plugins[name] = type;
                Console.WriteLine($"Plugin '{name}' registered.");
            }
        }

        public static IImageEffect CreatePlugin(string name, params object[] args)
        {
            if (plugins.ContainsKey(name))
            {
                return (IImageEffect)Activator.CreateInstance(plugins[name], args);
            }
            throw new Exception($"Plugin '{name}' not found.");
        }
    }

}
