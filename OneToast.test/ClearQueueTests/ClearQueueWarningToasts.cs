using One.Toast.Services;
using One.Toast.Tests.ToastServiceTests.Base;
using Xunit;

namespace One.Toast.Tests.ToastServiceTests.ClearQueueTests;

public class ClearQueueWarningToasts : BaseClearQueueTest
{
    protected override ToastLevel _toastLevel => ToastLevel.Warning;

    protected Action _call;

    public ClearQueueWarningToasts() : base()
    {
        _call = _sut.ClearQueueWarningToasts;
    }

    [Fact]
    public void OnClearQueueToastsInvoked_When_ClearQueueWarningToastsCalled()
        => OnClearInvoked_When_ClearCalled(_eventAction, _call);

    [Fact]
    public void OnClearQueueToastsContainsToastLevelWarning_When_ClearQueueWarningToastsCalled()
        => OnClearToastsContainsToastLevel_When_ClearCalled(_eventAction, _call, _toastLevel);
}
