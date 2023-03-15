using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;
using Dapper;

namespace RecipeBizObjects
{
    public class bizRecipeIngredient : bizObject<bizRecipeIngredient>
    {

        string IngredientDescval = "";

        public string IngredientDesc
        {
            get
            {
                return IngredientDescval;
            }
            set
            {
                IngredientDescval = value;
                InvokePropertyChanged();
            }
        }


    }
}
