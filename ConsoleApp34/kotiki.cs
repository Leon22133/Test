using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticheskai_Rabota_8
{
    internal class kotiki
    {
        public string Name;
        public int minute;
        public float sec;

        public kotiki(string names, int letter_minute, float letter_sec)
        {
            Name = names;
            minute = letter_minute;
            sec = letter_sec;
        }
    }
}