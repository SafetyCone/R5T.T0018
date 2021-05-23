using System;


namespace R5T.T0018
{
    /// <summary>
    /// Data-as-code for the different ASP.NET Core related environment variables recognized by the web host (and generic host).
    /// </summary>
    /// <remarks>
    /// See: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host?view=aspnetcore-5.0#override-configuration
    /// And see: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-5.0#host-configuration
    /// </remarks>
    public static class EnvironmentVariableNames
    {
        public const string AspNetCorePrefix = "ASPNETCORE_";

        public const string ApplicationNameSuffix = "APPLICATIONNAME";
        public const string ContentRootSuffix = "CONTENTROOT";
        public const string EnvironmentSuffix = "ENVIRONMENT";
        public const string ShutdownTimeoutSecondsSuffix = "SHUTDOWNTIMEOUTSECONDS";
        public const string ReloadConfigOnChangeSuffix = "hostBuilder:reloadConfigOnChange";

        public static readonly string ApplicationName = $"{AspNetCorePrefix}{ApplicationNameSuffix}";
        public static readonly string ContentRoot = $"{AspNetCorePrefix}{ContentRootSuffix}";
        public static readonly string Environment = ApplyAspNetCorePrefix(EnvironmentSuffix);
        public static readonly string ShutdownTimeoutSeconds = ApplyAspNetCorePrefix(ShutdownTimeoutSecondsSuffix);
        public static readonly string ReloadConfigOnChange = ApplyAspNetCorePrefix(ReloadConfigOnChangeSuffix);

        public const string CaptureStartupErrorsSuffix = "CAPTURESTARTUPERRORS";
        public const string DetailedErrorsSuffix = "DETAILEDERRORS";
        public const string HostingStartupAssembliesSuffix = "HOSTINGSTARTUPASSEMBLIES";
        public const string HostingStartupExcludeAssembliesSuffix = "HOSTINGSTARTUPEXCLUDEASSEMBLIES";
        public const string HttpsPortSuffix = "HTTPS_PORT";
        public const string PreferHostingUrlsSuffix = "PREFERHOSTINGURLS";
        public const string PreventHostingStartupSuffix = "PREVENTHOSTINGSTARTUP";
        public const string StartupAssemblySuffix = "STARTUPASSEMBLY";
        public const string UrlsSuffix = "URLS";
        public const string WebRootSuffix = "WEBROOT";

        public static readonly string CaptureStartupErrors = ApplyAspNetCorePrefix(CaptureStartupErrorsSuffix);
        public static readonly string DetailedErrors = ApplyAspNetCorePrefix(DetailedErrorsSuffix);
        public static readonly string HostingStartupAssemblies = ApplyAspNetCorePrefix(HostingStartupAssembliesSuffix);
        public static readonly string HostingStartupExcludeAssemblies = ApplyAspNetCorePrefix(HostingStartupExcludeAssembliesSuffix);
        public static readonly string HttpsPort = ApplyAspNetCorePrefix(HttpsPortSuffix);
        public static readonly string PreferHostingUrls = ApplyAspNetCorePrefix(PreventHostingStartupSuffix);
        public static readonly string PreventHostingStartup = ApplyAspNetCorePrefix(PreventHostingStartupSuffix);
        public static readonly string StartupAssembly = ApplyAspNetCorePrefix(StartupAssemblySuffix);
        public static readonly string Urls = ApplyAspNetCorePrefix(UrlsSuffix);
        public static readonly string WebRoot = ApplyAspNetCorePrefix(WebRootSuffix);


        private static string ApplyAspNetCorePrefix(string value)
        {
            var output = $"{EnvironmentVariableNames.AspNetCorePrefix}{value}";
            return output;
        }
    }
}
