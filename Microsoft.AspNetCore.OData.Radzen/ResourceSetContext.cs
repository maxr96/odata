﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.OData.Edm;

namespace Microsoft.AspNetCore.OData
{
    /// <summary>
    /// Contains context information about the resource set currently being serialized.
    /// </summary>
    public class ResourceSetContext
    {
        /// <summary>
        /// Gets or sets the HTTP request that caused this instance to be generated.
        /// </summary>
        public HttpRequest Request { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="HttpContext"/>.
        /// </summary>
        public HttpContext Context { get; set; }

        /// <summary>
        /// Gets the <see cref="IEdmEntitySetBase"/> this instance belongs to.
        /// </summary>
        public IEdmEntitySetBase EntitySetBase { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="IUrlHelper"/> to be used for generating links while serializing this
        /// feed instance.
        /// </summary>
        public IUrlHelper Url { get; set; }

        /// <summary>
        /// Gets the value of this feed instance.
        /// </summary>
        public object ResourceSetInstance { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="IEdmModel"/> to which this instance belongs.
        /// </summary>
        public IEdmModel EdmModel
        {
            get
            {
                return Context.ODataFeature().Model;
            }
        }
    }
}
