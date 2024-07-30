using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Pharmacist
    {
        public void CreateMedicine(IRecipe recipe)
        {
            recipe.GetIngridents();
            recipe.Mix();
            recipe.Prepare();
        }
    }
}
