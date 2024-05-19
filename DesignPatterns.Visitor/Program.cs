using DesignPatterns.Visitor;

var document = new Document();
document.AddElement(new Paragraph());
document.AddElement(new Image());
document.AddElement(new Paragraph());

var processor = new DocumentProcessor();
document.ProcessElements(processor);

Console.ReadKey();