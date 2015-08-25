﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Microsoft.VisualStudio.Composition
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using System.IO;
    using System.Reflection;
    using Microsoft.VisualStudio.Composition;

    internal static class ExportProviderFactory
    {
        internal static IExportProviderFactory LoadDefault()
        {
            var cacheManager = new CachedComposition();
            string cachePath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "$ConfigurationAssemblyName$");
            using (var cacheStream = File.OpenRead(cachePath))
            {
                return cacheManager.LoadExportProviderFactoryAsync(cacheStream, Resolver.DefaultInstance).GetAwaiter().GetResult();
            }
        }
   }
}
