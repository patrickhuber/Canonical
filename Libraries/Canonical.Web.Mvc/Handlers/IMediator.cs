using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.Web.Mvc.Handlers
{
    public interface IMediator
    {
        TResponse Request<TResponse>(IQuery<TResponse> query);
        TResult Send<TResult>(ICommand<TResult> query);
    }
}
