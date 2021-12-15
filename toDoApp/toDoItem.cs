namespace ToDo;

public class ToDoItem {
    public ToDoItem() {}
//field
    public bool IsDone { get; set; }
    public string Note { get; set; }

//method
    public void CompleteItem() {
        this.IsDone = true;
    }

    public string Print()
    {
        return $"Note: {this.Note} Done: {this.IsDone}";
    }
}