﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class bizSteps : bizObject<bizSteps>
    {

        string stepdescval = "";

        public string StepDesc
        {
            get
            {
                return stepdescval;
            }
            set
            {
                stepdescval = value;
                InvokePropertyChanged();
            }

        }

    }
}
