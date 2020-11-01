using System.Collections.Generic;

namespace AprajitaRetails.Shared.Models.ToDos
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Todos { get; set; }
        public IEnumerable<TodoItem> Dones { get; set; }
        public IEnumerable<TodoItem> PublicTodos { get; set; }
        public IEnumerable<TodoItem> AssignedTodos { get; set; }//TODO : new additions
    }
}
