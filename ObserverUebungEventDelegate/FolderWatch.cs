using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverUebungEventDelegate
{
    class FolderWatch
    {
        public delegate void FileAddedDelegate(string file);
        public event FileAddedDelegate FileAddedEvent;

        public FolderWatch (string folder)
        {

        }
        public void FileAdded(string file)
        {
            if(FileAddedEvent != null)
            {
                FileAddedEvent.Invoke(file);
            }
        }
    }
}
