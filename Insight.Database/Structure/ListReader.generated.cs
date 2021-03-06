﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Insight.Database.Structure;

namespace Insight.Database.Structure
{
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	public class ListReader<T1, T2> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2> : ListReader<T1, T2>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2> Default = new ListReaderAdapter<TList, T1, T2>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	public class ListReader<T1, T2, T3> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3> : ListReader<T1, T2, T3>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3> Default = new ListReaderAdapter<TList, T1, T2, T3>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4> : ListReader<T1, T2, T3, T4>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4> Default = new ListReaderAdapter<TList, T1, T2, T3, T4>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5> : ListReader<T1, T2, T3, T4, T5>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6> : ListReader<T1, T2, T3, T4, T5, T6>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7> : ListReader<T1, T2, T3, T4, T5, T6, T7>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	/// <typeparam name="T14">The type of the data in the fourteenth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	/// <typeparam name="T14">The type of the data in the fourteenth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	/// <typeparam name="T14">The type of the data in the fourteenth subobject.</typeparam>
	/// <typeparam name="T15">The type of the data in the fifteenth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	/// <typeparam name="T14">The type of the data in the fourteenth subobject.</typeparam>
	/// <typeparam name="T15">The type of the data in the fifteenth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
	/// <summary>
	/// Reads a list of objects from a data reader.
	/// </summary>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	/// <typeparam name="T14">The type of the data in the fourteenth subobject.</typeparam>
	/// <typeparam name="T15">The type of the data in the fifteenth subobject.</typeparam>
	/// <typeparam name="T16">The type of the data in the sixteenth subobject.</typeparam>
	public class ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ListReader<T1>
	{
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new IQueryReader<IList<T1>> Default = new ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();

		/// <summary>
		/// Initializes a new instance of the ListReader class.
		/// </summary>
		public ListReader() : base(OneToOne<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Records)
		{
		}
	}	

	/// <summary>
	/// Allows ListReader to return any of the interfaces implemented by List.
	/// Used by InterfaceGenerator. Not intended to be used by user code.
	/// </summary>
	/// <typeparam name="TList">The type of list to return.</typeparam>
	/// <typeparam name="T1">The type of the data in the first subobject.</typeparam>
	/// <typeparam name="T2">The type of the data in the second subobject.</typeparam>
	/// <typeparam name="T3">The type of the data in the third subobject.</typeparam>
	/// <typeparam name="T4">The type of the data in the fourth subobject.</typeparam>
	/// <typeparam name="T5">The type of the data in the fifth subobject.</typeparam>
	/// <typeparam name="T6">The type of the data in the sixth subobject.</typeparam>
	/// <typeparam name="T7">The type of the data in the seventh subobject.</typeparam>
	/// <typeparam name="T8">The type of the data in the eighth subobject.</typeparam>
	/// <typeparam name="T9">The type of the data in the nineth subobject.</typeparam>
	/// <typeparam name="T10">The type of the data in the tenth subobject.</typeparam>
	/// <typeparam name="T11">The type of the data in the eleventh subobject.</typeparam>
	/// <typeparam name="T12">The type of the data in the twelfth subobject.</typeparam>
	/// <typeparam name="T13">The type of the data in the thirteenth subobject.</typeparam>
	/// <typeparam name="T14">The type of the data in the fourteenth subobject.</typeparam>
	/// <typeparam name="T15">The type of the data in the fifteenth subobject.</typeparam>
	/// <typeparam name="T16">The type of the data in the sixteenth subobject.</typeparam>
	public class ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ListReader<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, IQueryReader<TList>
	{
		#region Fields
		/// <summary>
		/// The default reader to read a list of type T.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
		public static readonly new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Default = new ListReaderAdapter<TList, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		#endregion

		#region Methods
		/// <inheritdoc/>
		TList IQueryReader<TList>.Read(IDbCommand command, IDataReader reader)
		{
			return (TList)base.Read(command, reader);
		}

		/// <inheritdoc/>
		Task<TList> IQueryReader<TList>.ReadAsync(IDbCommand command, IDataReader reader, CancellationToken ct)
		{
			return base.ReadAsync(command, reader, ct).ContinueWith(t => (TList)t.Result, TaskContinuationOptions.ExecuteSynchronously);
		}

		/// <inheritdoc/>
		Type IQueryReader.ReturnType
		{
			get
			{
				return typeof(TList);
			}
		}
		#endregion
	}
}
