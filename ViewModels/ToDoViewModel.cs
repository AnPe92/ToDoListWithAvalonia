using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataModel;
using ToDoList.Services;

namespace ToDoList.ViewModels
{
    public class ToDoViewModel
    {
        private ToDoListService _service;
        public ToDoItem ToDo{ get; private set; }

        public ReactiveCommand<Unit,Unit> RemoveToDoCommand { get; private set; }

        public ToDoViewModel(ToDoItem todoItem, ToDoListService service)
        {
            _service = service;
            ToDo = todoItem;
            RemoveToDoCommand = ReactiveCommand.Create(() =>
            {
                _service.RemoveToDoItem(ToDo);
            });
        }
    }
    
}
