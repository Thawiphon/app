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
    /// desserts_List ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Idesserts_ListViewModel
    {		
        /// <summary>
        /// Gets/Sets the Desserts_ListListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.dessertsSchema> Desserts_ListListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Desserts_ListListControlCollectionPageNumber property.
        /// </summary>
		int Desserts_ListListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the Selecteddesserts_ListListControlCollection property.
        /// </summary>
		Entities.dessertsSchema Selecteddesserts_ListListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the Getdesserts_ListListControlCollectionCommand command.
        /// </summary>
		ICommand Getdesserts_ListListControlCollectionCommand { get; }

	}
}
