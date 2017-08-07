using System;
using TestTool.Helpers;

namespace TestTool.Model
{
    public class Tool : PropertyBase
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get { return _id; }
        }
        
        private string _name = string.Empty;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _length = 0;
        public int Length
        {
            get { return _length; }
            set
            {
                if (_length == value)
                    return;

                _length = value;
                OnPropertyChanged();
            }
        }

        private int _width = 0;
        public int Width
        {
            get { return _width; }
            set
            {
                if (_width == value)
                    return;

                _width = value;
                OnPropertyChanged();
            }
        }

        private int _diameter = 0;
        public int Diameter
        {
            get { return _diameter; }
            set
            {
                if (_diameter == value)
                    return;

                _diameter = value;
                OnPropertyChanged();
            }
        }

        private ToolTypeEnum _toolType = ToolTypeEnum.TubingHanger;
        public ToolTypeEnum ToolType
        {
            get { return _toolType; }
            set
            {
                if (_toolType == value)
                    return;

                _toolType = value;
                OnPropertyChanged();
            }
        }
    }
}
