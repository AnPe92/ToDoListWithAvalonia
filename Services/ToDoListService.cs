using DynamicData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataModel;

namespace ToDoList.Services
{
    public class ToDoListService
    {
        public HashSet<ToDoItem> ToDoItemsList { get; private set; }
        public HashSet<ToDoItem> CompletedToDoItemsList { get; private set; }

        public ToDoListService()
        {
            ToDoItemsList = new HashSet<ToDoItem>();
            ToDoItemsList.Add(new ToDoItem("Städa"));
       
        }

        public ToDoItem GetToDoItem(string description)
        {
            return ToDoItemsList.Where(item => item.Description.Equals(description)).FirstOrDefault();
        }
        public void SetToDoToCompleted(ToDoItem item)
        {
            item.IsChecked = true;
        }
        public bool AddToDoItem(ToDoItem item)
        {
            return ToDoItemsList.Add(item);
        }

        public bool RemoveToDoItem(ToDoItem item)
        {
            return ToDoItemsList.Remove(item);
        }

        public bool AddCompletedToDoItem(ToDoItem item)
        {
            return CompletedToDoItemsList.Add(item);
        }
        public bool RemoveCompletedToDoItem(ToDoItem item)
        {
            return CompletedToDoItemsList.Remove(item);
        }

        public ObservableCollection<ToDoItem> GetAllToDoItems()
        {
            return new ObservableCollection<ToDoItem>(ToDoItemsList);
        }
        public ObservableCollection<ToDoItem> GetAllCompeltedToDoItems()
        {
            return new ObservableCollection<ToDoItem>(CompletedToDoItemsList);
        }
        public void ClearAllCompletedToDoItems()
        {
            CompletedToDoItemsList.Clear();
        }


    }
}
