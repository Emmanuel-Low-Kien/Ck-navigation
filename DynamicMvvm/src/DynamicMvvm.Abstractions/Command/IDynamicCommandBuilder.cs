﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.DynamicMvvm
{
	/// <summary>
	/// This is a builder that builds a <see cref="IDynamicCommand"/>.
	/// </summary>
	public interface IDynamicCommandBuilder
	{
		/// <summary>
		/// Gets name of the command.
		/// This cannot be changed.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// The <see cref="IViewModel"/> that will own the resulting <see cref="IDynamicCommand"/>.
		/// </summary>
		/// <remarks>
		/// This can be null.
		/// </remarks>
		IViewModel ViewModel { get; }

		/// <summary>
		/// Gets the base stragegy that actually invokes the user execution.
		/// This cannot be changed.
		/// </summary>
		IDynamicCommandStrategy BaseStrategy { get; }

		/// <summary>
		/// The list of strategies that will decorate the <see cref="BaseStrategy"/>.
		/// The order is important: the first strategy wraps the second, which wraps the third and so on.
		/// </summary>
		IList<DelegatingCommandStrategy> Strategies { get; set; }

		/// <summary>
		/// Creates a new instance of <see cref="IDynamicCommand"/>
		/// </summary>
		IDynamicCommand Build();
	}
}
