using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public static class Helper
    {
        public static string GenerareCodUnic(string prefix)
        {
            Random rand = new Random();
            int randomCode = rand.Next();
            return $"{prefix} {randomCode}";
        }
    }
}
