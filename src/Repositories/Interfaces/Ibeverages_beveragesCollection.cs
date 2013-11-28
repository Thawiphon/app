// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// beverages_beveragesCollection interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Ibeverages_beveragesCollection
    {
		ObservableCollection<Entities.beveragesSchema> GetData(int pageNumber = 0);
		ObservableCollection<Entities.beveragesSchema> Search(FilterSpecification filter);
		bool HasPrevious(Entities.beveragesSchema current);
		bool HasNext(Entities.beveragesSchema current);
		Entities.beveragesSchema Previous(Entities.beveragesSchema current);
		Entities.beveragesSchema Next(Entities.beveragesSchema current);
    }
}
