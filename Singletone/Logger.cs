using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySamples
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        public void Update()
        {
            _instance = new Logger();
        }
        public void Log(string message)
        {
            // Hier könnte der Code zum Schreiben der Log-Nachricht in eine Datei stehen
            Console.WriteLine(message);
        }
    }

}
