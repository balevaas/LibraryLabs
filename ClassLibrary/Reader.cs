using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Reader
    {
        public string FIO {  get; set; }
        public int NumberGroop { get; set; }
        public int CountBook { get; set; }
        public Reader(string fio, int numberGroop, int countBook)
        {
            FIO = fio;
            NumberGroop = numberGroop;
            CountBook = countBook;
        }
    }
}
