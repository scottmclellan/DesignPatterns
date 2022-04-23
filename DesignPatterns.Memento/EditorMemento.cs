using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class EditorMemento
    {
        private Editor _editor;
        private string _text;
        private int _curX;
        private int _curY;
        private int _selectionWidth;
        private DateTime _createdDate;

        public EditorMemento(Editor editor)
        {
            _editor = editor;
            _text = editor.Text;
            _curY = editor.CurY;
            _curX = editor.CurX;
            _selectionWidth = editor.SelectionWidth;
            _createdDate = DateTime.Now;
        }

        public void Restore()
        {
            Console.WriteLine($"\nRestoring memento from {_createdDate.ToLongTimeString()}");

            _editor.Text = _text;
            _editor.SetCursorPosition(_curX, _curY);
            _editor.SelectionWidth = _selectionWidth;
        }

    }
}
