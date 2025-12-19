// See https://aka.ms/new-console-template for more information




using SkullLearningGiorgio;

Console.WriteLine("Hello, World!");

// Make a New Type From The Class GradeBook called book, This class will be a school register
// Costruct with one Student ( You Can Add Many other with addStudent
GradeBook book = new GradeBook("Giorgio", "Manuel", "5Bi", (Half) 10); 

// Debugging With A Get
Console.WriteLine("Ciao nome: " + book.FirstName);


// Printing A custom ToString ( overrided )
Console.WriteLine($"Baka sensei{book.ToString()}");