using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKY_Hangman
{
    public static class RandomNumber
    {
        public static Random rand = new Random(Guid.NewGuid().GetHashCode());
        
    }
}
