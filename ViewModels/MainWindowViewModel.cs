using System.Collections.Generic;

namespace DesktopIconsOrganizer.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string HeaderText { get; } = "Desktop Organizer 🖥️";
    public List<OrganizeTypeComboBoxItem> OrganizeTypeOptions { get; set; } = [
        new OrganizeTypeComboBoxItem {
            DisplayName = "Alphabetical order",
            Value = OrganizeType.Alphabetical
        },
        new OrganizeTypeComboBoxItem {
            DisplayName = "File type",
            Value = OrganizeType.FileType
        }
    ];

    public OrganizeTypeComboBoxItem? SelectedOrganizeType { get; set; }

    public OrganizeType OrganizeBy { get; set; }

    public enum OrganizeType
    {
        Alphabetical,
        FileType
    }

    public record OrganizeTypeComboBoxItem
    {
        public required string DisplayName { get; set; }
        public required OrganizeType Value { get; set; }
    }

}