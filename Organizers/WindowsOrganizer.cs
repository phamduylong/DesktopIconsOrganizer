using System.Collections.Generic;
using System.IO;
using System;
using static DesktopIconsOrganizer.ViewModels.MainWindowViewModel;

namespace DesktopIconsOrganizer.Organizers
{
	public class WindowsOrganizer
	{
		public static bool Organize(OrganizeType organizeType)
		{
			try
			{
				List<string> filesAndDirectories = [];
				var filesOnDesktop = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
				if (filesOnDesktop is not null && filesOnDesktop.Length > 0)
				{
					filesAndDirectories.AddRange(filesOnDesktop);
				}

				var directoriesOnDesktop = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
				if (directoriesOnDesktop is not null && directoriesOnDesktop.Length > 0)
				{
					filesAndDirectories.AddRange(directoriesOnDesktop);
				}

				switch (organizeType)
				{
					case OrganizeType.Alphabetical:
						OrganizeByAlphabeticalOrder();
						break;
					case OrganizeType:
						OrganizeByFileType();
						break;
				}
			} catch {
				
				return false;
			}

			return true;
		}

		private static void OrganizeByFileType()
		{
			throw new NotImplementedException();
		}

		private static void OrganizeByAlphabeticalOrder()
		{
			throw new NotImplementedException();
		}
	}
}
