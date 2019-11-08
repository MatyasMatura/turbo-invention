using System;

namespace DisplayHelper2
{
    public class Display
    {
        private LabelItem[] _array = new LabelItem[10];
        int _x, _y, _width, _height;
        private int _temp = 0;
        private int _tempAmmount;
        public int Count
        {
            get
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] == null)
                    {
                        return i;
                    }
                }
                return _array.Length;
            }
        }
        public Display(int x, int y, int width = 80, int height = 4)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
        public void AddItem(LabelItem item)
        {
            _array[_temp] = item;
            _temp++;
            _tempAmmount = _temp;
        }
        public void Refresh()
        {
            Border();
            for (int i = 0; i < Count; i++)
            {
                Console.SetCursorPosition(_x + 2, _height / 2 + _y + 1 + i);
                Console.Write(_array[i].Name);
                Console.SetCursorPosition(_x + 15, _height / 2 + _y + 1 + i);
                Console.Write(_array[i].Value);
            }
        }
        private void Border()
        {
            for (int i = 0; i < _width; i++)
            {
                Console.SetCursorPosition(i + _x, _y);
                Console.Write("-");
                Console.SetCursorPosition(i + _x, _y + 1 + _height + _tempAmmount);
                Console.Write("-");
            }
            for (int i = _y + 1; i < _height + _y + 1 + _tempAmmount; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write("|");
                Console.SetCursorPosition(_width + _x, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(_x, _y);
            Console.Write("+");
            Console.SetCursorPosition(_x, _y + 1 + _height + _tempAmmount);
            Console.Write("+");
            Console.SetCursorPosition(_width + _x, _y + 1 + _height + _tempAmmount);
            Console.Write("+");
            Console.SetCursorPosition(_width + _x, _y);
            Console.Write("+");
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}