using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class OnlyMeatMusaka : Musaka
    {
        // всеки нов клас ще си имплементира override за името
        public override void PrintAbstractName()
        {
            throw new NotImplementedException();
        }
    }
}
