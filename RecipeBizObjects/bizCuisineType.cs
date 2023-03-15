using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class bizCuisineType:bizObject<bizCuisineType>
    {

        int cuisinetypeidval;
        string cuisinetypenameval = "";

        public int CuisineTypeId
        {
            get
            {
                return cuisinetypeidval;
            }
            set
            {
                cuisinetypeidval = value;
                InvokePropertyChanged();
            }
        }

        public string CuisineTypeName
        {
            get
            {
                return cuisinetypenameval;
            }
            set
            {
                cuisinetypenameval = value;
                InvokePropertyChanged();
            }
        }
   



    }
}
