using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Games
{
    public class Boss:Enemy
    {
        public Boss():base("queen spider")
        {
            health = 300;
        }
    }
}
