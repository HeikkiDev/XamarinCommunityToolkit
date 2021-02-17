using System;

namespace Xamarin.CommunityToolkit.Effects
{
	public class TouchLongPressedEventArgs: EventArgs
	{
		internal TouchLongPressedEventArgs(object parameter)
			=> Parameter = parameter;

		public object Parameter { get; }
	}
}