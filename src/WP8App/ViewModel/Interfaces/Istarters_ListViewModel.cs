// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// starters_List ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Istarters_ListViewModel
    {		
        /// <summary>
        /// Gets/Sets the Starters_ListListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.startersSchema> Starters_ListListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Starters_ListListControlCollectionPageNumber property.
        /// </summary>
		int Starters_ListListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedstarters_ListListControlCollection property.
        /// </summary>
		Entities.startersSchema Selectedstarters_ListListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the Getstarters_ListListControlCollectionCommand command.
        /// </summary>
		ICommand Getstarters_ListListControlCollectionCommand { get; }

	}
}
