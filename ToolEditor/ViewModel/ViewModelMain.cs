using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.Data;
using TestTool.Model;

namespace TestTool.ViewModel
{
    public class ViewModelMain
    {
        public ObservableCollection<Tool> Tools { get; set; }
        

        public ViewModelMain()
        {
            Tools = FakeToolData.GetTools();
        }
    }
}
