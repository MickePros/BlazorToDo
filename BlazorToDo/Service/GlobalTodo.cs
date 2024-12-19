namespace BlazorToDo.Service
{
    public class GlobalTodo
    {
        public List<TodoItem> todos = new();

        public event Action? OnChange;

        public void Add(TodoItem item)
        {
            todos.Add(item);
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
