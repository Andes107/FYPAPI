using System.Web.Http;
using System.Web.Http.Controllers;

namespace FYPAPI.BindingAttribute
{
    public class IfNoneMatchAttribute : ParameterBindingAttribute
    {
        public override HttpParameterBinding GetBinding(HttpParameterDescriptor parameter)
        {
            return new ETagParameterBinding(parameter);
        }
    }
}