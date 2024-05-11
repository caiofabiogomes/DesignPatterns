// See https://aka.ms/new-console-template for more information

var file1 = new DesignPatterns.Composite.File("Document1.txt");
var file2 = new DesignPatterns.Composite.File("Document2.txt");
var file3 = new DesignPatterns.Composite.File("Document3.txt");


var directory1 = new DesignPatterns.Composite.Composite.DirectoryComposite("Folder1");
directory1.Add(file1);
directory1.Add(file2);

var directory2 = new DesignPatterns.Composite.Composite.DirectoryComposite("Folder2");
directory2.Add(file3);

var root = new DesignPatterns.Composite.Composite.DirectoryComposite("Root");
root.Add(directory1);
root.Add(directory2);
 
root.Display(0);

Console.ReadKey();