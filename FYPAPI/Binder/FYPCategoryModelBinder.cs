using System.Collections.Generic;
using System.Linq;
using FYPAPI.Infrastructure.Models;
using System.Web.Http.ModelBinding;
using System.Web.Http.Controllers;
using System.Web.Http.ValueProviders;

namespace FYPAPI.Binder
{
    public class FYPCategoryModelBinder: IModelBinder
    {
        private static List<string> _categories = new List<string>();
        static FYPCategoryModelBinder()
        {
            _categories.Add("Artificial Intelligence");
            _categories.Add("Computer Games");
            _categories.Add("Computer Security");
            _categories.Add("Database");
            _categories.Add("Embedded Systems and Software");
            _categories.Add("Human Language Technology");
            _categories.Add("Miscellaneous");
            _categories.Add("Mobile and Wireless Computing");
            _categories.Add("Mobile Applications");
            _categories.Add("Mobile Gaming");
            _categories.Add("Networking");
            _categories.Add("Operating Systems");
            _categories.Add("Software Technology");
            _categories.Add("Theory");
            _categories.Add("Vision and Graphics");
        }
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(FYPCategory))
                return false;

            ValueProviderResult val = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (val == null)
                return false;

            string key = val.RawValue as string;
            if (key == null)
            {
                bindingContext.ModelState.AddModelError(
                    bindingContext.ModelName, "Wrong value type");
                return false;
            }

            FYPCategory result = new FYPCategory();
            if (FYPCategory.TryParse(key, result) && !_categories.Any(cat => result.PK_tblFypCategories.Contains(cat)))
                result.PK_tblFypCategories = null;
            bindingContext.Model = result;
            return true;
        }
    }
}