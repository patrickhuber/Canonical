using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Canonical.Web.Mvc.Handlers
{
    public class Mediator : IMediator
    {
        private IDependencyResolver _depdendencyResolver;

        public Mediator(IDependencyResolver dependencyResolver)
        {
            _depdendencyResolver = dependencyResolver; 
        }

        public TResponse Request<TResponse>(IQuery<TResponse> query)
        {
            var handler = _depdendencyResolver.GetService<IQueryHandler<IQuery<TResponse>, TResponse>>();
            return handler.Handle(query);
        }

        public TResult Send<TResult>(ICommand<TResult> command)
        {
            var handler = _depdendencyResolver.GetService<ICommandHandler<ICommand<TResult>, TResult>>();
            return handler.Handle(command);
        }
    }
}
