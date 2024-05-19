namespace DesignPatterns.Visitor
{
    public class DocumentProcessor : IVisitor
    {
        public void VisitParagraph(Paragraph paragraph)
        {
            paragraph.FormatText();
        }

        public void VisitImage(Image image)
        {
            image.ResizeImage();
        }
    }

}
