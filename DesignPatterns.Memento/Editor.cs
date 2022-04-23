using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Editor
    {
        private string _text;
        private int _curX;
        private int _curY;
        private int _selectionWidth;

        public string Text { get => _text; set => _text = value; }
        public int SelectionWidth { get => _selectionWidth; set => _selectionWidth = value; }
        public int CurX { get => _curX; set => _curX = value; }
        public int CurY { get => _curY; set => _curY = value; }

        public void SetCursorPosition(int curX, int curY)
        {
            CurX = curX;
            CurY = curY;
        }

        public EditorMemento CreateMemento()
        {
            return new EditorMemento(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nEditor State");
            sb.AppendLine($"Text: {_text}");
            sb.AppendLine($"Selection Width:{_selectionWidth}");
            sb.AppendLine($"Cursor Position: (X:{_curX} Y:{_curY})");

            return sb.ToString();
            
      }
    }
}
