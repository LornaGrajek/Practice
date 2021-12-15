using ToDo;
//namespace that holds a collection called List. its similar to array, but automatically resizes for you.m
using System.Collections.Generic;

bool exit = false;
//instantiates a new list called ToDoList with ToDoItems
List<ToDoItem> ToDoList = new List<ToDoItem>();

do
{
    
    Console.WriteLine("Welcome to the ToDo list");
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("1: Create a new todo item");
    Console.WriteLine("2: View my list");
    Console.WriteLine("3: Complete an item");
    Console.WriteLine("x: Exit");
    string input = Console.ReadLine();
    // // instantiating an instance of a custom class
    // ToDoItem item = new ToDoItem();
    // // assigning values to this particular instance
    // item.IsDone = false;
    // item.Note = "Eat food";
    // // using the class' method
    // Console.WriteLine(item.Print());
    // item.CompleteItem();
    // Console.WriteLine(item.Print());

    switch(input)
    {
        case "1":
            Console.WriteLine("Make a new item");
            Console.WriteLine("Item Note: ");
            string newNote = Console.ReadLine();
            ToDoItem newItem = new ToDoItem();
            newItem.IsDone = false;
            newItem.Note = newNote;
            ToDoList.Add(newItem);
            Console.WriteLine($"You created the following item: {newItem.Print()}");
        break;
        case "2":
            Console.WriteLine("View the list");
            foreach(ToDoItem item in ToDoList)
            {
                Console.WriteLine(item.Print());
            }
        break;
        case "3":
            Console.WriteLine("Complete an item");
        break;
        case "x":
            Console.WriteLine("Goodbye!");
            exit = true;
            break;
        default:
            Console.WriteLine("I'm not sure of that command");
        break;
    }
    
} while (!exit);
