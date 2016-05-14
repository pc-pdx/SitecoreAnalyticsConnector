# SitecoreAnalyticsConnector
Connection and utilization of lytics segments in sitecore

# Setup
1.  Clone the repo
2.  Copy your sitecore versions Sitecore.Kernel.dll and Newtonsoft.Json.dll to the dependencies folder outside of the project
3.  Edit the csproj file to complete the postbuild command that'll move the binaries and configs to the proper sitecore instance
  1.  Make sure you revert these before submitting a PR

