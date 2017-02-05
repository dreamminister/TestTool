using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TestTool.Data;
using TestTool.Helpers;
using TestTool.Model;

namespace TestTool.ViewModel
{
    public class ViewModelMain : PropertyBase
    {
        public ObservableCollection<Tool> Tools { get; set; }
        public ICommand AddToolCommand { get; set; }
        public ICommand RemoveToolCommand { get; set; }
        public bool IsAnyToolSelected { get { return SelectedTool != null; } }

        private Tool _selectedTool = null;

        private int _commonDiameter = 0;
        public int CommonDiameter
        {
            get { return _commonDiameter; }
            set
            {
                if (_commonDiameter == value)
                    return;

                _commonDiameter = value;
                UpdateToolsDiameter(value);
                OnPropertyChanged<int>();
            }
        }

        private void UpdateToolsDiameter(int value)
        {
            foreach (var tool in Tools)
                tool.Diameter = value;
        }

        public Tool SelectedTool
        {
            get { return _selectedTool; }

            set
            {
                if (_selectedTool != value)
                {
                    _selectedTool = value;
                    OnPropertyChanged<object>();
                    OnPropertyChanged<bool>("IsAnyToolSelected");
                }
            }
        }

        public ViewModelMain()
        {
            Tools = FakeToolData.GetTools();
            AddToolCommand = new AddToolCommand(Tools);
            RemoveToolCommand = new RemoveToolCommand(Tools);
        }
    }
}
