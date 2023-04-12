﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chinook.DynamicMvvm
{
	public static partial class DynamicCommandStrategyExtensions
	{
		/// <summary>
		/// Will execute the command on a background thread.
		/// </summary>
		/// <param name="builder">The builder.</param>
		/// <returns><see cref="IDynamicCommandBuilder"/></returns>
		public static IDynamicCommandBuilder OnBackgroundThread(this IDynamicCommandBuilder builder)
			=> builder.WithStrategy(new BackgroundCommandStrategy());
	}

	/// <summary>
	/// This <see cref="DelegatingCommandStrategy"/> will execute the command on a background thread.
	/// </summary>
	public class BackgroundCommandStrategy : DelegatingCommandStrategy
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BackgroundCommandStrategy"/> class.
		/// </summary>
		public BackgroundCommandStrategy()
		{
		}

		/// <inheritdoc />
		public override Task Execute(CancellationToken ct, object parameter, IDynamicCommand command)
		{
			return Task.Run(() => base.Execute(ct, parameter, command));
		}
	}
}
