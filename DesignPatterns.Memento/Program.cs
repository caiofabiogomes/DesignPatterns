using DesignPatterns.Memento;

var editor = new TextEditor();
var history = new TextEditorHistory();

editor.Text = "Hello, World!";

history.Push(editor.Save());

editor.Text = "This is a new line.";

history.Push(editor.Save());

editor.Restore(history.Pop());

Console.ReadKey();