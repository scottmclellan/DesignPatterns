using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class History
    {       
        private Stack<EditorMemento> _history = new Stack<EditorMemento>();

        public void CreateHistory(Editor editor)
        {
            _history.Push(editor.CreateMemento());
          
        }

        public void Restore()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("Nothing to restore");
                return;
            }

            var memento = _history.Pop();

            memento.Restore();
        }

    }
}
