using Avalonia.Controls;
using DesktopIconsOrganizer.Organizers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using static DesktopIconsOrganizer.ViewModels.MainWindowViewModel;

namespace DesktopIconsOrganizer.Views;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void OrganizeButton_OnClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
		OrganizeType selected = OrganizeType.Alphabetical;
		ComboBox? organizeTypeCB = this.FindNameScope()?.Find<ComboBox>("organizeType");
		if(organizeTypeCB is null)
		{
			selected = OrganizeType.Alphabetical;
		} else if(organizeTypeCB.SelectedValue is not null)
		{
			selected = ((OrganizeTypeComboBoxItem) organizeTypeCB.SelectedValue).Value;
		}

		if (OperatingSystem.IsWindows())
		{
			WindowsOrganizer.Organize(selected);
		}
		else if (OperatingSystem.IsLinux())
		{
			// Linux class required
		}
		else if (OperatingSystem.IsMacOS())
		{
			// MACOS class
		}
	}
}