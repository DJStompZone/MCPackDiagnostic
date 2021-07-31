using fNbt;
using System.IO;
using System.Threading.Tasks;

namespace MCDiagnostics.API.Level
{
	public static class Tag
	{
		/// <summary>
		/// Get a tag value from a world.
		/// </summary>
		/// <param name="levelDat">The level.dat file to parse.</param>
		/// <param name="tag">The tag to get.</param>
		/// <returns>Returns the value of the given tag.</returns>
		public static async Task<(string, bool)> GetTagAsync(Stream levelDat, string tag)
		{
			if (levelDat != null && tag != null)
			{
				try
				{
					NbtFile file = new NbtFile { BigEndian = false };
					using (MemoryStream ms = new MemoryStream())
					{
						await levelDat.CopyToAsync(ms);
						byte[] data = ms.ToArray();
						file.LoadFromBuffer(data, 8, data.Length - 8, NbtCompression.None);
						NbtCompound compoundTag = file.RootTag;
						return (compoundTag.Get(tag).StringValue, true);
					}
				}
				catch
				{
					return (string.Empty, false);
				}
			}
			else
			{
				return (string.Empty, false);
			}
		}
	}
}