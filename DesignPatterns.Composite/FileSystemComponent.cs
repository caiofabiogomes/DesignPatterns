using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class FileSystemComponent
    {
        protected string Name;

        public FileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }

}
