﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. 

using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi.Validations.Visitors
{
    /// <summary>
    /// Visit <see cref="OpenApiResponses"/>.
    /// </summary>
    internal class ResponsesVisitor : VisitorBase<OpenApiResponses>
    {
        /// <summary>
        /// Visit the children of the <see cref="OpenApiResponses"/>.
        /// </summary>
        /// <param name="context">The validation context.</param>
        /// <param name="responses">The <see cref="OpenApiResponses"/>.</param>
        protected override void Next(ValidationContext context, OpenApiResponses responses)
        {
            if (context == null)
            {
                throw Error.ArgumentNull(nameof(context));
            }

            if (responses == null)
            {
                throw Error.ArgumentNull(nameof(responses));
            }

            context.ValidateMap(responses);

            base.Next(context, responses);
        }
    }
}
