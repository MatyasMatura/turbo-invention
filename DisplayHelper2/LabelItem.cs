using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayHelper2
{
    public class LabelItem
    {
        private string _name; //např. slovo "Věk"
        private object _value; //např. 22

        public LabelItem(string name, object value = null)
        {
            _name = name;
            _value = value;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Value
        {
            get
            {
                return _value?.ToString();
            }
        }
    }
}
