// using Microsoft.AspNetCore.Components;

// namespace Amsthetic.Pages
// {
//     public partial class Roadmap : ComponentBase
//     {
//         protected int currentCount = 0;

//         protected void IncrementCount()
//         {
//             currentCount++;
//         }

//          public class TodoItem
//         {
//             public string? Title { get; set; }
//             public bool IsDone { get; set; }
//         }

//         private bool inputVisible {get; set;} = true;
//         private bool btnVisible {get; set;} = false;
//         private List<TodoItem> todos = new();
//         private string? newTodo;
//         protected void InputVisible()
//         {
//             inputVisible = !inputVisible;
//             btnVisible = !btnVisible;
//         }
//         private void AddTodo()
//         {
//             if (!string.IsNullOrWhiteSpace(newTodo))
//             {
//                 todos.Add(new TodoItem { Title = newTodo });
//                 newTodo = string.Empty;
//                 InputVisible();
//             }
//         }
//         private void RemoveTodo(TodoItem listItem)
//         {
//             todos.Remove(listItem);
//         }
//     }
// }