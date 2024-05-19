namespace DesignPatterns.Memento
{
    public class TextEditorHistory
    {
        private Stack<TextMemento> _history = new Stack<TextMemento>();

        public void Push(TextMemento memento)
        {
            _history.Push(memento);
        }

        public TextMemento Pop()
        {
            return _history.Pop();
        }
    }
}
