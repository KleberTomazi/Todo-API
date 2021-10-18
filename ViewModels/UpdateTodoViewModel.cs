using System.ComponentModel.DataAnnotations;

namespace MyTodo.ViewModels
{
    public class UpdateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
