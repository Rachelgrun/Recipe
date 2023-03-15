using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.ComponentModel.DataAnnotations;



namespace RecipeBizObjects
{
    public class bizRecipe:bizObject<bizRecipe>
    {
        
        string recipenameval = "";
        int numberofcaloriesval;
        int numingredientsval;
        int numstepsval;
        int createdbyuseridval;
        int Cuisinetypeval;
        string statusval;
        int useridval;
        DateTime? datepublishedval;
        DateTime? datearchivedval;
        string codeval = "";
        string userfullnameval = "";
        string cuisinetypeval = "";

        

       DateTime DateDraftedval = DateTime.Now;

        public bizRecipe()
        {
            this.DynamParamForUpdates.Output(this, x => x.Code);
        }
     
        //public void Load(int Id)
        //{
        //    DataTable dt = base.Load(Id);

        //    if (dt.Rows.Count > 0)
        //    {
        //        DataRow dr = dt.Rows[0];
        //        this.RecipeName = dr["RecipeName"].ToString();
        //        this.Calories = (int)dr["Calories"];
        //        this.NumberOfIngredients = (int)dr["NumberOfIngredients"];
        //        this.NumberOfSteps = (int)dr["NumberOfSteps"];
        //        this.DateDrafted = (DateTime)dr["DateDrafted"];
        //        if(dr["DateArchived"] != DBNull.Value)
        //        {
        //            this.DateArchived = (DateTime?)dr["DateArchived"];
        //        }

        //        if (dr["DatePublished"] != DBNull.Value)
        //        {
        //            this.DateArchived = (DateTime?)dr["DatePublished"];
        //        }
        //        this.CuisineTypeId = (int)dr["CuisineTypeId"];
        //        this.CreatedByUserId = (int)dr["CreatedByUserId"];
        //        this.RecipeStatus = (string)dr["RecipeStatus"];
        //    }
        //}

        public void Save()
        {
            DynamicParameters dp = new DynamicParameters(this);
            dp.Output<bizRecipe>(this, x => x.RecipeId);
            dp.Output<bizRecipe>(this, x => x.DateDrafted);

            SQLUtility.ExecuteSQLDapper(SprocName(SprocActionEnum.Update), dp);
           
         
        }

        //public List<string> IngredientList
        
        //  { get => this.IngredientList; set => this.IngredientList = value; }
        //public List<string> StepList
        //{ get => this.StepList; set => this.StepList = value; }

        public string FullDesc() { return this.RecipeName + ": Status:" + this.RecipeStatus + " Cal:" + this.Calories + " NumIngredients:" + this.NumberOfIngredients + " Num Steps:" + this.NumberOfSteps; }
        [Display(Name ="Recipe Status")]
        public string RecipeStatus
        {
            get
            {
                return statusval;
            }
            set
            {
                statusval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Date Published")]
        public DateTime? DatePublished
        {
            get
            {
                return datepublishedval;
            }
            set
            {
                datepublishedval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name ="Date Archived")]
        public DateTime? DateArchived
        {
            get
            {
                return datearchivedval;
            }
            set
            {
                datearchivedval = value;
                InvokePropertyChanged();
            }
          
        }


       [Display(Name ="Cuisine Type")]
        public int CuisineTypeId
        {
            get
            {
                return Cuisinetypeval;
            }
            set
            {
                Cuisinetypeval = value;
                InvokePropertyChanged();

            }
        }
        [Display(Name ="Date Drafted")]
        public DateTime DateDrafted
        {
            get
            {
                return DateDraftedval;
            }
            set
            {
                DateDraftedval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name ="User Name")]
        public int CreatedByUserId
        {
            get
            {
                return createdbyuseridval;
                

            }
            set
            {
                createdbyuseridval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name ="Recipe Name")]
        public string RecipeName
        {
            get
            {
                return recipenameval;
              
            }
            set
            {
                recipenameval = value;
                InvokePropertyChanged();
            }
        }

        [Display(Name ="Number Of Ingredients")]
        public int NumberOfIngredients
        {
            get
            {
                return numingredientsval;
            }
            set
            {
                numingredientsval = value;
                InvokePropertyChanged();
            }
        }

        public int Calories
        {
            get
            {
                return numberofcaloriesval;
            }
            set
            {
                numberofcaloriesval = value;
                InvokePropertyChanged();
            }
        }

        [Display(Name ="Number Of Steps")]
        public int NumberOfSteps
        {
            get
            {
                return numstepsval;

            }
            set
            {
                numstepsval = value;
                InvokePropertyChanged();
            }
        }



        public string Code
        {
            get
            {
                return codeval;
            }
            set
            {
                codeval = value;
                InvokePropertyChanged();
            }
        }

        public string UserFullName
        {
            get
            {
                return userfullnameval;
            }
            set
            {
                userfullnameval = value;
                InvokePropertyChanged();
            }
        }

        public string CuisineTypeName
        {
            get
            {
                return cuisinetypeval;
            }
            set
            {
                cuisinetypeval = value;
                InvokePropertyChanged();
            }
        }

        public int RecipeId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }


        //public List<bizRecipeIngredient> IngredientDesc()
        //{

        //        lstingredients = bizRecipeIngredient.GetList("RecipeId", this.RecipeId);

        //    return lstingredients;
        //}
        public List<bizRecipeIngredient> RecipeIngredientList()
        {
            return bizRecipeIngredient.GetList("RecipeId",this.RecipeId);
        }


        public List<bizSteps> StepsList()
        {
            return bizSteps.GetList("RecipeId",this.RecipeId);
        }

        public  List<bizUsers> UserList()
        {
            List<bizUsers> users = bizUsers.GetAll();

            return users;
        }

        public List<bizCuisineType> CuisineTypeList()
        {
            return bizCuisineType.GetAll();
        }
       
    }

    
}


