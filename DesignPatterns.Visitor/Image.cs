namespace DesignPatterns.Visitor
{
    public class Image : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitImage(this);
        }

        public void ResizeImage()
        {
            Console.WriteLine("Resizing image...");
        }
    }
}
