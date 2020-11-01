using AprajitaRetails.Areas.ToDo.Models;
using System.Collections.Generic;

namespace AprajitaRetails.Shared.Models.ToDos
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class HomeViewModel
    {
        public IEnumerable<TodoItem> RecentlyAddedTodos { get; set; }
        public IEnumerable<TodoItem> CloseDueToTodos { get; set; }
        public IEnumerable<TodoItem> MonthlyToTodos { get; set; }
        public CalendarViewModel CalendarViewModel { get; set; }
        public IEnumerable<TodoItem> PublicTodos { get; set; }
    }
}
