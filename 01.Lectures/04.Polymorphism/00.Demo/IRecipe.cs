using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    // може да наследим и IBaseRecipe в IRecipe
    public interface IBaseRecipe
    {
        void Mix();
        void Prepare();
    }
    public interface IRecipe : IBaseRecipe
    {
        void GetIngridents();

    }
}
