using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.CSS
{
    public class FilerLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}




