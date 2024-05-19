namespace DesignPatterns.Visitor
{
    public class Paragraph : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitParagraph(this);
        }

        public void FormatText()
        {
            Console.WriteLine("Formatting paragraph text...");
        }
    }
}
