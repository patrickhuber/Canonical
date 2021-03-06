﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.Web.Mvc.Handlers
{
    public interface IQueryHandler<TRequest, TResponse>
        where TRequest : IQuery<TResponse>
    {
        TResponse Handle(TRequest query);
    }
}
