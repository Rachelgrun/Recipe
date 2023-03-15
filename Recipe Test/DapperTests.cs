using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CPUFramework;
using System.Data.SqlClient;
using System.Data;
using RecipeBizObjects;
using Dapper;


namespace Recipe_Test
{

    internal class DapperTests
    {


        int totalrecipe = 0;
        int maxrecipeid = 0;
        string connstring = "";
        string minrecipeidname = "";
        int recipeincookbook = 0;
        int minrecipeid = 0;
        int minrecipeidsteps = 0;
        int randomuserid = 0;
        int randomcuisineid = 0;
        [SetUp]
        public void Setup()
        {
           
            connstring = DataUtility.SetConnectionString("rgrunwald.database.windows.net,1433", "RecipeDB", "rgrunwaldadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.RecipeName, TotalSteps = COUNT(distinct rs.StepSequence), r.calories, r.CreatedByUserId from recipe r join RecipeIngredient ri on r.RecipeId = ri.RecipeId join Step rs on r.RecipeId = rs.RecipeId group by r.RecipeId, r.RecipeName, r.Calories, r.CreatedByUserId order by r.recipeId");
            minrecipeid = (int)dt.Rows[0]["RecipeId"];
            minrecipeidsteps = (int)dt.Rows[0]["TotalSteps"];
            minrecipeidname = (string)dt.Rows[0]["RecipeName"];

            dt = SQLUtility.GetDataTable(connstring, "select total = Count(*) from Recipe r ");
            totalrecipe = (int)dt.Rows[0]["total"];


            dt = SQLUtility.GetDataTable(connstring, "select r.RecipeId from recipe r order by RecipeId Desc");
            maxrecipeid = (int)dt.Rows[0]["RecipeId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.RecipeName, c.CookbookTitle from recipe r join RecipeCookBook rc on rc.RecipeID = r.recipeId join CookBook c on rc.CookbookId = c.CookbookId");
            recipeincookbook = (int)dt.Rows[0]["RecipeId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 u.userid from users u");
            randomuserid = (int)dt.Rows[0]["UserId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 c.CuisineTypeid from CuisineType c");
            randomcuisineid = (int)dt.Rows[0]["CuisineTypeId"];
        }

     
        private bizRecipe LoadRecipe(int id)
        {
            bizRecipe recipe = bizRecipe.Get(id);


                return recipe;

            
        }

        private List<bizRecipe> LoadListRecipe()
        {
            return bizRecipe.GetAll();
        }
        private bizRecipe InsertNewRecipe()
        {
            bizRecipe recipe = new bizRecipe();
            recipe.RecipeName = "Peanut Butter Cookies " + DateTime.Now;
            recipe.DateDrafted = System.DateTime.Now.AddDays(-30);
            recipe.DatePublished = System.DateTime.Now;
            recipe.Calories = 236;
            recipe.CreatedByUserId = randomuserid;
            recipe.CuisineTypeId = randomcuisineid;
            recipe.DateArchived = DateTime.Now;


            //DynamicParameters dp = new DynamicParameters(recipe);
            //dp.Output<bizRecipe>(recipe, x => x.RecipeId);

            //using (SqlConnection conn = GetConnection())
            //{
            //    conn.Execute("RecipeUpdate", dp, commandType: CommandType.StoredProcedure);
            //}
            recipe.Save();
            return recipe;
        }

        private int DeleteRecipe(int id = 0)
        {

            bizRecipe r;
            if(id == 0)
            {
                r = this.InsertNewRecipe();
            }
            else
            {
                r = this.LoadRecipe(id);
            }
            id = r.RecipeId;
            //using (SqlConnection conn =GetConnection())
            //{
            //    DynamicParameters dp = new DynamicParameters();
            //    dp.Add("RecipeId", id);
            //    conn.Execute("RecipeDelete", dp, commandType: CommandType.StoredProcedure);

            //}
            r.Delete();
            return id;
        }

        private void ChangeRecipeName(bizRecipe recipe)
        {
            string recipename = minrecipeidname += " " + DateTime.Now.ToString();
            recipe.RecipeName = recipename;
            recipe.Save();

            //DynamicParameters dp = new DynamicParameters(recipe);
            //using (SqlConnection conn = GetConnection()) 
            //{
            //    conn.Execute("RecipeUpdate", dp, commandType: CommandType.StoredProcedure);
            //}
        }


             [Test]
         public void TestLoadRecipeList()
        {
            List<bizRecipe> lst = this.LoadListRecipe();
            TestContext.WriteLine("num of recipe" + lst.Count);
            Assert.IsTrue(lst.Count == totalrecipe);
        }

        [Test]

        public void TestLoadRecipe()
        {
            bizRecipe r = this.LoadRecipe(minrecipeid);
            TestContext.WriteLine(r.FullDesc());
            Assert.IsTrue(r.NumberOfSteps == minrecipeidsteps);
        }


        [Test]
        public void TestUpdateRecipe()
        {
            bizRecipe recipe = this.LoadRecipe(minrecipeid);
            string recipename = recipe.RecipeName;
            
            this.ChangeRecipeName(recipe);
           // recipe = this.LoadRecipe(maxrecipeid);
            TestContext.WriteLine("Original: " + recipename + " Current: " + recipe.RecipeName );
            Assert.IsTrue(recipe.RecipeName == minrecipeidname);
        }
        [Test]
        public void TestDeleteNewRecipe()
        {
            int id = this.DeleteRecipe();
            bizRecipe r = this.LoadRecipe(id);
           Assert.IsTrue( r.RecipeId ==0);
        }

    }
}
