using System.IO;
using System.Reflection;

namespace Gladiator
{
    public class Resource
    {
        private readonly string _resourceName;

        public Resource(string name)
        {
            _resourceName = name;
        }

        public override string ToString()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}