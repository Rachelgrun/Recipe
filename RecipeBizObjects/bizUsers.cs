using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public class bizUsers:bizObject<bizUsers>
    {
        int useridval;
        //string userfirstnameval = "";
        //string userlastnameval = "";
        string fullnameval = "";

        public int UsersId
        {
            get
            {
                return useridval;
            }
            set
            {
                useridval = value;
                InvokePropertyChanged();
            }
        }

        public string FullName
        {
            get
            {
                return fullnameval;
            }
            set
            {
                fullnameval = value;
                InvokePropertyChanged();
            }
        }
        //public object UserName()
        //{
            
        // return bizUsers.Get("FullName", this.FullName);
         

        //}
    }
}
