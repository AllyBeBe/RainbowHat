using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieTicketPriceCalculator
{
	public static class Time
	{
		private static DateTime? _utcNow;

		/// <summary>
		/// Gets a System.DateTime object that is set to the current date and time on
		/// this computer, expressed as the Coordinated Universal Time (UTC).
		/// </summary>
		public static DateTime UtcNow
		{
			get
			{
				return _utcNow ?? DateTime.UtcNow;
			}
			private set
			{
				_utcNow = value;
			}
		}

		/// <summary>
		/// Gets a System.DateTime object that is set to the current date and time on
		/// this computer, expressed as the local time.
		/// </summary>
		public static DateTime Now
		{
			get
			{
				return UtcNow.ToLocalTime();
			}
			private set
			{
				UtcNow = value.ToUniversalTime();
			}
		}
	
		/// <summary>
		/// Freezes the current time using the UTC DateTime passed in. Don't forget
		/// to dispose the returned DisposableAction.
		/// </summary>
		/// <remarks>
		/// Local date time kinds are converted to UTC using DateTime.ToUniversalTime().
		/// </remarks>
		/// <param name="time">The UTC DateTime to freeze at.</param>
		/// <returns>A disposable action which unfreezes time.</returns>
		public static IDisposable FreezeUtcAt(DateTime time)
		{
			if (time.Kind == DateTimeKind.Local)
			{
				time = time.ToUniversalTime();
			}
			UtcNow = DateTime.SpecifyKind(time, DateTimeKind.Utc);
			return new DisposableAction(ResetToSystemTime);
		}

		/// <summary>
		/// Freezes the current time using the local DateTime passed in. Don't forget
		/// to dispose the returned DisposableAction.
		/// </summary>
		/// <remarks>
		/// Local date time kinds are converted to local time using DateTime.ToLocalTime().
		/// </remarks>
		/// <param name="time">The UTC DateTime to freeze at.</param>
		/// <returns>A disposable action which unfreezes time.</returns>
		public static IDisposable FreezeAt(DateTime time)
		{
			if (time.Kind == DateTimeKind.Utc)
			{
				time = time.ToLocalTime();
			}
			Now = DateTime.SpecifyKind(time, DateTimeKind.Local);
			return new DisposableAction(ResetToSystemTime);
		}

		private static void ResetToSystemTime()
		{
			_utcNow = null;
		}
	}
}
