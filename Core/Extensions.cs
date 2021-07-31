namespace MCDiagnostics.Core
{
	public static class Extensions
	{
		/// <summary>
		/// Replace null by the wanted value.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">The array to analyze.</param>
		/// <param name="replace">The value that will replace null.</param>
		/// <returns></returns>
		public static T[] ReplaceNullBy<T>(this T[] array, T replace, int defaultLength = 3)
		{
			if (array == null)
			{
				array = new T[defaultLength];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = replace;
				}
				return array;
			}
			else
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						array[i] = replace;
					}
					else
					{
						array[i] = array[i];
					}
				}
				return array;
			}
		}
	}
}
