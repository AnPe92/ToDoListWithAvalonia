using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.DataModel;
using ToDoList.Services;

namespace ToDoList.ViewModels
{
    public class ToDoListViewModel: ViewModelBase
    {
        private ToDoListService _toDoListService;

        public ToDoListViewModel(ObservableCollection<ToDoItem> items)
        {
            _toDoListService = new ToDoListService();
            ListItems =items;            
            
            foreach(var item in ListItems) 
            {
                var todoViewModel = new ToDoViewModel(item, _toDoListService);
                todoViewModel.RemoveToDoCommand.Subscribe(_ => ToDoList.Remove(todoViewModel));
                ToDoList.Add(todoViewModel);  
            }
        }
        public ObservableCollection<ToDoViewModel> ToDoList { get; } = new ObservableCollection<ToDoViewModel>();
            

        public ObservableCollection<ToDoItem> ListItems { get; }

        public void ChangeView(MainWindowViewModel mainWindow)
        {
            ViewModelBase view = new CompletedItemsViewModel();
            mainWindow.ChangeViewModel(view);
        }
               
        

        
    }
}
