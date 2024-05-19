namespace DesignPatterns.Visitor
{
    public class Document
    {
        private List<IDocumentElement> _elements = new List<IDocumentElement>();

        public void AddElement(IDocumentElement element)
        {
            _elements.Add(element);
        }

        public void ProcessElements(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
