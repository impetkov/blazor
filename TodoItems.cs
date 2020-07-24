namespace BlazorApp
{
    using System.Collections;
    using System.Collections.Generic;

    public class TodoItems : IEnumerable<TodoItem>
    {
        private readonly List<TodoItem> inner;

        public TodoItems()
        {
            inner = new List<TodoItem>();
        }

        public void Add(string title)
        {
            var toAdd = new TodoItem(title);
            inner.Add(toAdd);
        }

        public IEnumerator<TodoItem> GetEnumerator() =>
            inner.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();
    }
}