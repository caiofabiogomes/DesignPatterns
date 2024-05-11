namespace DesignPatterns.Composite
{
    public class File : FileSystemComponent
    {
        public File(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " " + Name);
        }
    }

}
