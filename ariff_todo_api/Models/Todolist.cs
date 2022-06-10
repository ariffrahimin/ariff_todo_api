using System;
using System.Collections.Generic;

namespace Ariff_db_todo.Models
{
    public partial class Todolist
    {
        public int ListId { get; set; }
        public string ListContent { get; set; } = null!;
        public string ListStatus { get; set; } = null!;
    }
}
