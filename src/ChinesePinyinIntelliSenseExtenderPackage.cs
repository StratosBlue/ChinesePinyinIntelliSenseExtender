using System;
using System.Runtime.InteropServices;
using System.Threading;
using ChinesePinyinIntelliSenseExtender.Options;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace ChinesePinyinIntelliSenseExtender;

[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[Guid(ChinesePinyinIntelliSenseExtenderPackage.PackageGuidString)]
[ProvideOptionPage(typeof(OptionPages.General), "IntelliSense拼音补全", "常规", 0, 0, true)]
public sealed class ChinesePinyinIntelliSenseExtenderPackage : AsyncPackage
{
    /// <summary>
    /// ChinesePinyinIntelliSenseExtenderPackage GUID string.
    /// </summary>
    public const string PackageGuidString = "cd4393db-d533-4077-93da-9fdad98ddacf";

    #region Package Members

    protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        return base.InitializeAsync(cancellationToken, progress);
    }

    #endregion Package Members
}
