namespace DesignPatterns.Memento
{
    public class TextEditor
    {
        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                Console.WriteLine($"Text set to: {value}");
                _text = value;
            }
        }

        public TextMemento Save()
        {
            Console.WriteLine("Saving state...");
            return new TextMemento(_text);
        }

        public void Restore(TextMemento memento)
        {
            _text = memento.Text;
            Console.WriteLine($"Restored state: {_text}");
        }
    }
}
