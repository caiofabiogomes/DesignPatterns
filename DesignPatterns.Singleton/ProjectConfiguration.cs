using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    // example of singeton pattern
    public class ProjectConfiguration
    {
        private ProjectConfiguration() { }

        private static ProjectConfiguration _instance;

        public static ProjectConfiguration GetInstance()
        {
            if (_instance is null)
            {
                _instance = new ProjectConfiguration();
                Console.WriteLine("New instance created");
            }
            else
            {
                Console.WriteLine("Instance already exists");
            }

            return _instance;
        }
    }
}
