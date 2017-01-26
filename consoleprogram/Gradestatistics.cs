using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleprogram
{
    public class Gradestatistics
    {
        public Gradestatistics ()
	{
            Higheststats =0;
            Loweststats = float.MaxValue;
	}
        public float Higheststats;
        public float Loweststats;
        public float averagesats;
    }
}
