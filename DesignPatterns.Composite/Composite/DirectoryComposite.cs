namespace DesignPatterns.Composite.Composite
{
    public class DirectoryComposite : FileSystemComponent
    {
        private List<FileSystemComponent> _children = new List<FileSystemComponent>();

        public DirectoryComposite(string name) : base(name)
        {
        }

        public void Add(FileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(FileSystemComponent component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + "+ " + Name);

            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }

}
