using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataModel;

namespace ToDoList.ViewModels
{
    public class CompletedItemsViewModel: ViewModelBase
    {
        public CompletedItemsViewModel()
        {
            List <ToDoItem> testList = new List <ToDoItem>();
            testList.Add(new ToDoItem("Number 1"));
            testList.Add(new ToDoItem("Number 2"));
            testList.Add(new ToDoItem("Number 3"));
            

            IEnumerable<ToDoItem> list = new ObservableCollection<ToDoItem>(testList) ;

            CompletedListItems = new ObservableCollection<ToDoItem>(list);

        }
        public ObservableCollection<ToDoItem> CompletedListItems { get; }
    }
}
