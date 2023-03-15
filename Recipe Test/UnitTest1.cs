using NUnit.Framework;
using CPUFramework;
using System.Data.SqlClient;
using System.Data;
using RecipeBizObjects;
using Dapper;

namespace Recipe_Test
{
    public class Tests
    {
        int totalrecipe = 0;
        int maxrecipeid = 0;
        string connstring = "";
        int recipethatsarchived = 0;
//AS Add test for zero calories
        int recipeincookbook = 0;
        int minrecipeid = 0;
        int minrecipeidsteps = 0;
        [SetUp]
        public void Setup()
        {
           connstring = DataUtility.SetConnectionString("rgrunwald.database.windows.net,1433", "RecipeDB", "rgrunwaldadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.RecipeName, TotalSteps = COUNT(distinct rs.StepSequence), r.calories, r.CreatedByUserId from recipe r join RecipeIngredient ri on r.RecipeId = ri.RecipeId join Step rs on r.RecipeId = rs.RecipeId group by r.RecipeId, r.RecipeName, r.Calories, r.CreatedByUserId order by r.recipeId");
            minrecipeid = (int)dt.Rows[0]["RecipeId"];
            minrecipeidsteps = (int)dt.Rows[0]["TotalSteps"];
            dt = SQLUtility.GetDataTable(connstring, "select total = Count(*) from Recipe r ");
            totalrecipe = (int)dt.Rows[0]["total"];


            dt = SQLUtility.GetDataTable(connstring, "select r.RecipeId from recipe r order by RecipeId Desc");
            maxrecipeid = (int)dt.Rows[0]["RecipeId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.RecipeName, c.CookbookTitle from recipe r join RecipeCookBook rc on rc.RecipeID = r.recipeId join CookBook c on rc.CookbookId = c.CookbookId");
            //recipeincookbook = (int)dt.Rows[0]["RecipeId"];


        }
        [Test]

        public void TestRecipeList()
        {
            DataTable dt = DataService.GetRecipeList();
            TestContext.WriteLine("number of recipes " + dt.Rows.Count.ToString());
            Assert.IsTrue(dt.Rows.Count == totalrecipe);

        }
        [Test]
        public void TestLoadNewRecipe()
        {
            // LL when trying to load a new recipe, this is not the way to do it. 
            // LL you have to load up a new instance of bizRecipe and supply all the properties, then save it
            bizRecipe recipe =bizRecipe.Get(minrecipeid);
           
            TestContext.WriteLine(" recipe FullDesc = " + recipe.FullDesc());
            Assert.IsTrue(recipe.NumberOfSteps == minrecipeidsteps );
        }

        [Test]
        public void TestLoadRecipeDapper()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
              bizRecipe recipe= conn.QueryFirstOrDefault<bizRecipe>("select top 1 * from recipe");
                TestContext.WriteLine(recipe.FullDesc());
            }
        }
        //[Test]
        //public void TestDeleteRecipeInCookBook()
        //{
        //    bizRecipe recipe =  bizRecipe.Get(recipeincookbook);
       
        //    Assert.Throws<CPUException>(() => recipe.Delete());
        //}




    }
}