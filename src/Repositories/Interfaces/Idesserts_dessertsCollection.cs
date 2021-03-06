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
    /// desserts_dessertsCollection interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Idesserts_dessertsCollection
    {
		ObservableCollection<Entities.dessertsSchema> GetData(int pageNumber = 0);
		ObservableCollection<Entities.dessertsSchema> Search(FilterSpecification filter);
		bool HasPrevious(Entities.dessertsSchema current);
		bool HasNext(Entities.dessertsSchema current);
		Entities.dessertsSchema Previous(Entities.dessertsSchema current);
		Entities.dessertsSchema Next(Entities.dessertsSchema current);
    }
}
