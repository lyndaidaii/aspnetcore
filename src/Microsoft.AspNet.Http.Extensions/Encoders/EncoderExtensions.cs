﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace Microsoft.AspNet.WebUtilities.Encoders
{
    /// <summary>
    /// Contains extension methods for fetching encoders from a service provider.
    /// </summary>
    public static class EncoderExtensions
    {
        /// <summary>
        /// Retrieves an IHtmlEncoder from a service provider.
        /// </summary>
        /// <remarks>
        /// This method is guaranteed never to return null.
        /// It will return a default encoder instance if the service provider does not contain one.
        /// </remarks>
        public static IHtmlEncoder GetHtmlEncoder([NotNull] this IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<IHtmlEncoder>() ?? HtmlEncoder.Default;
        }

        /// <summary>
        /// Retrieves an IJavaScriptStringEncoder from a service provider.
        /// </summary>
        /// <remarks>
        /// This method is guaranteed never to return null.
        /// It will return a default encoder instance if the service provider does not contain one.
        /// </remarks>
        public static IJavaScriptStringEncoder GetJavaScriptStringEncoder([NotNull] this IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<IJavaScriptStringEncoder>() ?? JavaScriptStringEncoder.Default;
        }

        /// <summary>
        /// Retrieves an IUrlEncoder from a service provider.
        /// </summary>
        /// <remarks>
        /// This method is guaranteed never to return null.
        /// It will return a default encoder instance if the service provider does not contain one.
        /// </remarks>
        public static IUrlEncoder GetUrlEncoder([NotNull] this IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<IUrlEncoder>() ?? UrlEncoder.Default;
        }
    }
}
