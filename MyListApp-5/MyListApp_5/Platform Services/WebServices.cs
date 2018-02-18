using System;
using Xamarin.Forms;

namespace MyListApp
{
	public static class WebServices
	{
		/// <summary>
		/// Is the server available.
		/// </summary>
		/// <returns><c>true</c>, if server available was ised, <c>false</c> otherwise.</returns>
		/// <param name="url">URL.</param>
		public static bool IsServerAvailable(String url)
		{
			return (DependencyService.Get<IPlatformServices>().IsServerAvailable(url));
		}
	}
}
