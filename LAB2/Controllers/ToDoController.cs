using Microsoft.AspNetCore.Mvc;
using LAB2.Models;

namespace LAB2.Controllers
{
    public class ToDoController : Controller
    {
        // Tạm lưu dữ liệu (giả lập)
        private static List<ToDoItem> toDoList = new List<ToDoItem>
        {
            new ToDoItem { Id = 1, Task = "Ôn tập HTML" },
            new ToDoItem { Id = 2, Task = "Ôn tập CSS" },
            new ToDoItem { Id = 3, Task = "Ôn tập Bootstrap" }
        };

        public IActionResult Index()
        {
            return View(toDoList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ToDoItem item)
        {
            item.Id = toDoList.Count > 0 ? toDoList.Max(i => i.Id) + 1 : 1;
            toDoList.Add(item);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var item = toDoList.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ToDoItem item)
        {
            var existing = toDoList.FirstOrDefault(i => i.Id == item.Id);
            if (existing != null)
            {
                existing.Task = item.Task;
            }
            return RedirectToAction("Index");
        }
    }
}
