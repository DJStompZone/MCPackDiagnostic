using System.Text.RegularExpressions;

namespace MCDiagnostics.API.Addons
{
	public static class Text
	{
		/// <summary>
		/// Remove any character that is used for color code in Minecraft.
		/// </summary>
		/// <param name="baseText">The text to clean.</param>
		/// <returns>Returns the cleaned string.</returns>
		public static string ParseColorCodes(string baseText)
		{
			if (baseText == null)
			{
				return "";
			}

			string pattern = "§.";
			string[] substrings = Regex.Split(baseText, pattern);

			return string.Join("", substrings);
		}
	}
}