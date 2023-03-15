using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeBizObjects
{
    public static class DataService
    {
       



        public static DataTable GetRecipeBookSummary()
        {
            return SQLUtility.GetDataTableFromSproc(DataUtility.ConnectionString, "RecipeBookGet");
        }

        public static DataTable GetRecipeList()
        {
            return SQLUtility.GetDataTableFromSproc(DataUtility.ConnectionString, "RecipeGet");
        }

        public static DataTable GetRecipeDetail(int id)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeDetailsGet");
            cmd.Parameters["@RecipeId"].Value = id;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);



        }
        public static DataTable GetIngredientList(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "IngredientListGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);

        }

        public static DataTable GetStepList(int recipeid)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "StepListGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }



    }
}
