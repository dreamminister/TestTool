using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TestTool.Model;

namespace TestTool.Helpers
{
    public class RemoveToolCommand : ICommand
    {
        private ObservableCollection<Tool> _tools;

        public RemoveToolCommand(ObservableCollection<Tool> tools)
        {
            _tools = tools;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _tools != null && parameter != null;
        }

        public void Execute(object parameter)
        {
            IList selectedItems = parameter as IList;
            if (selectedItems == null)
                return;

            var selectedTools = selectedItems.Cast<Tool>().ToList();

            foreach(var tool in selectedTools)
                _tools.Remove(tool);
        }
    }
}
