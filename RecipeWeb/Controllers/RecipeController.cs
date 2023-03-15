using CPUFramework;
using Microsoft.AspNetCore.Mvc;
using RecipeBizObjects;

namespace RecipeWeb.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            List<bizRecipe> lst = bizRecipe.GetAll();
            return View(lst);
        }

        public IActionResult RecipeDetails(string id)
        {
            bizRecipe recipe = bizRecipe.Get("Code",id);
            return View(recipe);
        }



        public ActionResult APIRecipeList()
        {
            List<bizRecipe> lst = bizRecipe.GetAll();
            return Json(lst);
        }
        public IActionResult APICuisineTypeList()
        {
            List<bizCuisineType> lst = bizCuisineType.GetAll();
            return Json(lst);
        }



        public IActionResult Edit(string id)
        {
            bizRecipe recipe;
            if(string.IsNullOrEmpty(id))
            {
                recipe = new();
            }
            else
            {
                recipe = bizRecipe.Get("Code", id);
            }


            return View(recipe);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(bizRecipe recipe)
        {
            try
            {
                recipe.Save();
            }
            catch (CPUException ex)
            {
                ViewBag.ErrorMessage = ex.FriendlyMessage;
            }
            return View(recipe);
        }

       
        public ActionResult Delete(string id)
        {
           bizRecipe r = bizRecipe.Get("Code", id);
            return View(r);
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(bizRecipe recipe)
        {
            try
            {
               recipe.Delete();
                return RedirectToAction(nameof(Index));
            }

            catch (CPUFramework.CPUException ex)
            {
                recipe = bizRecipe.Get(recipe.RecipeId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(recipe);
            }


        }
    
}
}
