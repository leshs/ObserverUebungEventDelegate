using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObserverUebungEventDelegate
{
    class Logger
    {
        private TextWriter textWriter = null;

        public Logger (TextWriter tw)
        {
            this.textWriter = tw;
        }

        public Logger(string logfile)
        {
            textWriter = new StreamWriter(logfile);
        }

        public void WriteLine(string file)
        {
            textWriter.WriteLine(file);
            textWriter.Flush();
        }
    }
}
