// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of desserts_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class desserts_DetailViewModel : ViewModelsBase.VMBase, IViewModels.Idesserts_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.desserts_dessertsCollection _desserts_dessertsCollection;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="desserts_DetailViewModel" /> class.
        /// </summary>
        /// <param name="desserts_dessertsCollection">The Desserts_desserts Collection.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public desserts_DetailViewModel(Repositories.desserts_dessertsCollection desserts_dessertsCollection, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_desserts_dessertsCollection = desserts_dessertsCollection;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.dessertsSchema _currentdessertsSchema;

        /// <summary>
        /// CurrentdessertsSchema property.
        /// </summary>		
        public Entities.dessertsSchema CurrentdessertsSchema
        {
            get
            {
				return _currentdessertsSchema;
            }
            set
            {
                SetProperty(ref _currentdessertsSchema, value);
            }
        }
	
		private bool _hasNextpanoramadesserts_Detail0;

        /// <summary>
        /// HasNextpanoramadesserts_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramadesserts_Detail0
        {
            get
            {
				return _hasNextpanoramadesserts_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramadesserts_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramadesserts_Detail0;

        /// <summary>
        /// HasPreviouspanoramadesserts_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramadesserts_Detail0
        {
            get
            {
				return _hasPreviouspanoramadesserts_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramadesserts_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechdesserts_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechdesserts_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentdessertsSchema.Subtitle + " " + CurrentdessertsSchema.Description);
        }
		

        private ICommand _textToSpeechdesserts_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechdesserts_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechdesserts_DetailStaticControlCommand
        {
            get { return _textToSpeechdesserts_DetailStaticControlCommand = _textToSpeechdesserts_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechdesserts_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Sharedesserts_DetailStaticControlCommand command.
        /// </summary>
        public  void Sharedesserts_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentdessertsSchema.Subtitle, CurrentdessertsSchema.Description, "", CurrentdessertsSchema.Image);
        }
		

        private ICommand _sharedesserts_DetailStaticControlCommand;

        /// <summary>
        /// Gets the Sharedesserts_DetailStaticControlCommand command.
        /// </summary>
        public ICommand Sharedesserts_DetailStaticControlCommand
        {
            get { return _sharedesserts_DetailStaticControlCommand = _sharedesserts_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(Sharedesserts_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartdesserts_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartdesserts_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.Idesserts_DetailViewModel), CreateTileInfodesserts_DetailStaticControl());
        }
		

        private ICommand _pinToStartdesserts_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartdesserts_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartdesserts_DetailStaticControlCommand
        {
            get { return _pinToStartdesserts_DetailStaticControlCommand = _pinToStartdesserts_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartdesserts_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Nextpanoramadesserts_Detail0 command.
        /// </summary>
        public  void Nextpanoramadesserts_Detail0Delegate() 
        {
			var next =  _desserts_dessertsCollection.Next(CurrentdessertsSchema);

			if(next != null)
				CurrentdessertsSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramadesserts_Detail0;

        /// <summary>
        /// Gets the Nextpanoramadesserts_Detail0 command.
        /// </summary>
        public ICommand Nextpanoramadesserts_Detail0
        {
            get { return _nextpanoramadesserts_Detail0 = _nextpanoramadesserts_Detail0 ?? new ViewModelsBase.DelegateCommand(Nextpanoramadesserts_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the Previouspanoramadesserts_Detail0 command.
        /// </summary>
        public  void Previouspanoramadesserts_Detail0Delegate() 
        {
			var prev =  _desserts_dessertsCollection.Previous(CurrentdessertsSchema);

			if(prev != null)
				CurrentdessertsSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramadesserts_Detail0;

        /// <summary>
        /// Gets the Previouspanoramadesserts_Detail0 command.
        /// </summary>
        public ICommand Previouspanoramadesserts_Detail0
        {
            get { return _previouspanoramadesserts_Detail0 = _previouspanoramadesserts_Detail0 ?? new ViewModelsBase.DelegateCommand(Previouspanoramadesserts_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramadesserts_Detail0 = _desserts_dessertsCollection.HasPrevious(CurrentdessertsSchema);
			HasNextpanoramadesserts_Detail0 = _desserts_dessertsCollection.HasNext(CurrentdessertsSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.dessertsSchema)) { return; }
                
                CurrentdessertsSchema = value as Entities.dessertsSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the desserts_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfodesserts_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentdessertsSchema.Id.ToString(),
                Title = CurrentdessertsSchema.Subtitle,
                BackTitle = CurrentdessertsSchema.Subtitle,
                BackContent = CurrentdessertsSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentdessertsSchema.Image,
                BackBackgroundImagePath = CurrentdessertsSchema.Image,
                LogoPath = "Logo-aa87c77c-d4e9-4a1d-82d9-d75b739152cb.png"
            };
            return tileInfo;
        }
    }
}
