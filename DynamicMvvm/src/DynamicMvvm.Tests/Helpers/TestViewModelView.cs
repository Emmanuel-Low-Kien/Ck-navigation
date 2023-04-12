﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chinook.DynamicMvvm.Tests.Helpers
{
	public class TestDispatcher : IDispatcher
	{
		private readonly bool _hasDispatcherAccess;
		private readonly Action<Action> _onExecuteOnDispatcher;

		public TestDispatcher(
			bool hasDispatcherAccess = false,
			Action<Action> onExecuteOnDispatcher = null
		)
		{
			_hasDispatcherAccess = hasDispatcherAccess;
			_onExecuteOnDispatcher = onExecuteOnDispatcher;
		}

		public bool GetHasDispatcherAccess() => _hasDispatcherAccess;

		public Task ExecuteOnDispatcher(CancellationToken ct, Action action)
		{
			_onExecuteOnDispatcher?.Invoke(action);
			return Task.CompletedTask;
		}

		public void Dispose()
		{
		}
	}
}
