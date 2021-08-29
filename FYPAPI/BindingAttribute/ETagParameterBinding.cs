using System.Linq;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;

namespace FYPAPI.BindingAttribute
{
    public class ETagParameterBinding : HttpParameterBinding
    {
        public ETagParameterBinding(HttpParameterDescriptor parameter) : base(parameter) { }
        public override Task ExecuteBindingAsync(ModelMetadataProvider metadataProvider, HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            EntityTagHeaderValue etag = actionContext.Request.Headers.IfNoneMatch.FirstOrDefault();

            if (etag != null)
                actionContext.ActionArguments[Descriptor.ParameterName] = etag.Tag;

            var tsc = new TaskCompletionSource<object>();
            tsc.SetResult(null);
            return tsc.Task;
        }
    }
}