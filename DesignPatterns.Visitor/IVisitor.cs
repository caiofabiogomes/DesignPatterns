namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void VisitParagraph(Paragraph paragraph);
        void VisitImage(Image image);
    }
}
