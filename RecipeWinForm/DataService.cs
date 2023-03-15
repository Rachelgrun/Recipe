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
        private static string connstring = "Server =tcp:rgrunwald.database.windows.net,1433; Initial Catalog=RecipeDB; Persist Security Info = False; User ID=rgrunwaldadmin; Password =CPU123!@#; MultipleActiveResultSets=False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
        public static DataTable GetRecipeBookSummary()
        {
            return SQLUtility.GetDataTableFromSproc(connstring, "RecipeBookGet");
        }

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(connstring, "RecipeGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd, connstring);
        }

        public static DataTable GetRecipeDetail(int id)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(connstring, "RecipeGet");
            cmd.Parameters["@RecipeId"].Value = id;
            return SQLUtility.GetDataTable(cmd,connstring);



        }
        public static DataTable GetIngredientList(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(connstring, "RecipeIngredienttGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd,connstring);

        }

        public static DataTable GetStepList(int recipeid)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(connstring, "StepsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd,connstring);
        }

        public static DataTable GetCuisineList(bool IncludeBlank = false)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(connstring, "CuisineTypeListGet");

            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = IncludeBlank;
            return CPUFramework.SQLUtility.GetDataTable(cmd, connstring);
        }

        public static DataTable GetUserNameList(bool IncludeBlank = false)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(connstring, "UserNameListGet");

            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = IncludeBlank;
            return CPUFramework.SQLUtility.GetDataTable(cmd, connstring);
        }
    }
}
