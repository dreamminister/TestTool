using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.Model;

namespace TestTool.Data
{
    class FakeToolData
    {
        public static ObservableCollection<Tool> GetTools()
        {
            return new ObservableCollection<Tool>
            {
                new Tool { Name = "Demo", Diameter = 1, Length = 2, Width = 3 }
            };
        }
    }
}
