using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class NivelDos
    {
        public static void Dos()
        {
            try
            {
                NivelTres.Tres();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: { ex } ");
                throw new Exception("nivel2", ex);
            }
        }
    }
}

