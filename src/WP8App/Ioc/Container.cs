// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc=WPAppStudio.Ioc.Interfaces;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Microsoft.Practices.Unity;
using Repositories=WPAppStudio.Repositories;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using Services=WPAppStudio.Services;
using ViewModels=WPAppStudio.ViewModel;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class Container : IIoc.IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<IServices.ILiveTileService, Services.LiveTileService>();
			_currentContainer.RegisterType<IServices.ILockScreenService, Services.LockScreenService>();
			_currentContainer.RegisterType<IServices.IProximityService, Services.ProximityService>();
            _currentContainer.RegisterType<IServices.IDialogService, Services.DialogService>();
            _currentContainer.RegisterType<IServices.IShareService, Services.ShareService>();
			
            _currentContainer.RegisterType<IServices.ISpeechService, Services.SpeechService>();
            _currentContainer.RegisterType<IServices.INavigationService, Services.NavigationService>();
			
		
		    _currentContainer.RegisterType<IServices.IStorageService, Services.StorageService>();
			_currentContainer.RegisterType<IServices.IInternetService, Services.InternetService>(new ContainerControlledLifetimeManager());
            _currentContainer.RegisterType<IViewModels.Inavigate_MenuViewModel, ViewModels.navigate_MenuViewModel>();
            _currentContainer.RegisterType<IViewModels.Istarters_ListViewModel, ViewModels.starters_ListViewModel>();
            _currentContainer.RegisterType<IViewModels.Istarters_DetailViewModel, ViewModels.starters_DetailViewModel>();
            _currentContainer.RegisterType<IViewModels.Idesserts_ListViewModel, ViewModels.desserts_ListViewModel>();
            _currentContainer.RegisterType<IViewModels.Idesserts_DetailViewModel, ViewModels.desserts_DetailViewModel>();
            _currentContainer.RegisterType<IViewModels.Ibeverages_ListViewModel, ViewModels.beverages_ListViewModel>();
            _currentContainer.RegisterType<IViewModels.Ibeverages_DetailViewModel, ViewModels.beverages_DetailViewModel>();

			_currentContainer.RegisterType<IViewModels.IAboutViewModel, ViewModels.AboutViewModel>(new ContainerControlledLifetimeManager());
			_currentContainer.RegisterType<IViewModels.ILicenseViewModel, ViewModels.LicenseViewModel>(new ContainerControlledLifetimeManager());
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
				_currentContainer.RegisterType<Repositories.Istarters_startersCollection, Repositories.starters_startersCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.Idesserts_dessertsCollection, Repositories.desserts_dessertsCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.Ibeverages_beveragesCollection, Repositories.beverages_beveragesCollection>(new ContainerControlledLifetimeManager());
			}
			else
			{
				_currentContainer.RegisterType<Repositories.Istarters_startersCollection, Repositories.Fakestarters_startersCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.Idesserts_dessertsCollection, Repositories.Fakedesserts_dessertsCollection>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<Repositories.Ibeverages_beveragesCollection, Repositories.Fakebeverages_beveragesCollection>(new ContainerControlledLifetimeManager());
			
			}
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
