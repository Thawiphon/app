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
    /// Implementation of starters_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class starters_DetailViewModel : ViewModelsBase.VMBase, IViewModels.Istarters_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.starters_startersCollection _starters_startersCollection;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="starters_DetailViewModel" /> class.
        /// </summary>
        /// <param name="starters_startersCollection">The Starters_starters Collection.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public starters_DetailViewModel(Repositories.starters_startersCollection starters_startersCollection, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_starters_startersCollection = starters_startersCollection;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.startersSchema _currentstartersSchema;

        /// <summary>
        /// CurrentstartersSchema property.
        /// </summary>		
        public Entities.startersSchema CurrentstartersSchema
        {
            get
            {
				return _currentstartersSchema;
            }
            set
            {
                SetProperty(ref _currentstartersSchema, value);
            }
        }
	
		private bool _hasNextpanoramastarters_Detail0;

        /// <summary>
        /// HasNextpanoramastarters_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramastarters_Detail0
        {
            get
            {
				return _hasNextpanoramastarters_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramastarters_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramastarters_Detail0;

        /// <summary>
        /// HasPreviouspanoramastarters_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramastarters_Detail0
        {
            get
            {
				return _hasPreviouspanoramastarters_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramastarters_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechstarters_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechstarters_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentstartersSchema.Subtitle + " " + CurrentstartersSchema.Description);
        }
		

        private ICommand _textToSpeechstarters_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechstarters_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechstarters_DetailStaticControlCommand
        {
            get { return _textToSpeechstarters_DetailStaticControlCommand = _textToSpeechstarters_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechstarters_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Sharestarters_DetailStaticControlCommand command.
        /// </summary>
        public  void Sharestarters_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentstartersSchema.Subtitle, CurrentstartersSchema.Description, "", CurrentstartersSchema.Image);
        }
		

        private ICommand _sharestarters_DetailStaticControlCommand;

        /// <summary>
        /// Gets the Sharestarters_DetailStaticControlCommand command.
        /// </summary>
        public ICommand Sharestarters_DetailStaticControlCommand
        {
            get { return _sharestarters_DetailStaticControlCommand = _sharestarters_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(Sharestarters_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartstarters_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartstarters_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.Istarters_DetailViewModel), CreateTileInfostarters_DetailStaticControl());
        }
		

        private ICommand _pinToStartstarters_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartstarters_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartstarters_DetailStaticControlCommand
        {
            get { return _pinToStartstarters_DetailStaticControlCommand = _pinToStartstarters_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartstarters_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Nextpanoramastarters_Detail0 command.
        /// </summary>
        public  void Nextpanoramastarters_Detail0Delegate() 
        {
			var next =  _starters_startersCollection.Next(CurrentstartersSchema);

			if(next != null)
				CurrentstartersSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramastarters_Detail0;

        /// <summary>
        /// Gets the Nextpanoramastarters_Detail0 command.
        /// </summary>
        public ICommand Nextpanoramastarters_Detail0
        {
            get { return _nextpanoramastarters_Detail0 = _nextpanoramastarters_Detail0 ?? new ViewModelsBase.DelegateCommand(Nextpanoramastarters_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the Previouspanoramastarters_Detail0 command.
        /// </summary>
        public  void Previouspanoramastarters_Detail0Delegate() 
        {
			var prev =  _starters_startersCollection.Previous(CurrentstartersSchema);

			if(prev != null)
				CurrentstartersSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramastarters_Detail0;

        /// <summary>
        /// Gets the Previouspanoramastarters_Detail0 command.
        /// </summary>
        public ICommand Previouspanoramastarters_Detail0
        {
            get { return _previouspanoramastarters_Detail0 = _previouspanoramastarters_Detail0 ?? new ViewModelsBase.DelegateCommand(Previouspanoramastarters_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramastarters_Detail0 = _starters_startersCollection.HasPrevious(CurrentstartersSchema);
			HasNextpanoramastarters_Detail0 = _starters_startersCollection.HasNext(CurrentstartersSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.startersSchema)) { return; }
                
                CurrentstartersSchema = value as Entities.startersSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the starters_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfostarters_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentstartersSchema.Id.ToString(),
                Title = CurrentstartersSchema.Subtitle,
                BackTitle = CurrentstartersSchema.Subtitle,
                BackContent = CurrentstartersSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentstartersSchema.Image,
                BackBackgroundImagePath = CurrentstartersSchema.Image,
                LogoPath = "Logo-aa87c77c-d4e9-4a1d-82d9-d75b739152cb.png"
            };
            return tileInfo;
        }
    }
}
