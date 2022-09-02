using System;
using System.Linq;
using System.Net;
using static Build.BuildSteps;

namespace Build
{
    class Program
    {
        static void Main(string[] args)
        {
            Orchestrator
                .CreateForTarget(args)
                .Then(Clean)
                .Then(DownloadTemplates)
                .Then(DownloadManifestUtility)
                .Then(BuildBundleBinariesForWindows)
                .Then(BuildBundleBinariesForLinux)
                .Then(BuildBundleBinariesForLinuxARM64)
                .Then(RunManifestUtilityWindows)
                .Then(RunManifestUtilityLinux)
                .Then(RunManifestUtilityLinuxARM64)
                .Then(PackageNetCoreV2Bundle)
                .Then(PackageNetCoreV3BundlesWindows)
                .Then(PackageNetCoreV3BundlesLinux)
                .Then(CreateRUPackage)
                .Then(CreateCDNStoragePackage)
                .Then(CreateCDNStoragePackageWindows)
                .Then(CreateCDNStoragePackageLinux)
                .Run();
        }
    }
}