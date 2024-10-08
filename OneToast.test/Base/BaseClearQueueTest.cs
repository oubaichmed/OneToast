﻿using One.Toast.Services;
using Xunit;

namespace One.Toast.Tests.ToastServiceTests.Base
{
    public abstract class BaseClearQueueTest : BaseClearTest
    {
        protected abstract ToastLevel _toastLevel { get; }

        protected Action<Action<ToastLevel>?> _eventAction;

        protected BaseClearQueueTest() : base()
        {
            _eventAction = x => _sut.OnClearQueueToasts += x;
        }
    }
}
