using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TestTool.Model;

namespace TestTool.Helpers
{
    public class AddToolCommand : ICommand
    {
        private ObservableCollection<Tool> _tools;

        public AddToolCommand(ObservableCollection<Tool> tools)
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
            return _tools != null;
        }

        public void Execute(object parameter)
        {
            _tools.Add(new Tool());
        }
    }
}
