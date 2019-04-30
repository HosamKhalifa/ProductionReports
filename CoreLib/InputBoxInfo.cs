using System;

namespace CoreLib
{
    public class InputBoxInfo
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public Type DataType { get; set; }
        public string ToolTip { get; set; }
        public Object InputValue { get; set; }

    }
}