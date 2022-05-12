﻿using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class MainViewModel : BaseModel
    {
        // Constructors
        public MainViewModel()
        {
            ApplicationVersion = "CHIP 1.00.00 beta";
            HelperMethods.CreateDirectories(ReferenceData.Directories);
            try
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new(typeof(CampaignViewModel));
                using System.IO.FileStream fs = new(ReferenceData.File_CampaignData, System.IO.FileMode.Open);
                CampaignView = (CampaignViewModel)xmlSerializer.Deserialize(fs);
                CampaignView!.ResetActiveItems();
            }
            catch
            {
                CampaignView = new();
            }
            ReferenceData.MainModelRef = this;
        }

        // Databound Properties
        private string _ApplicationVersion;
        public string ApplicationVersion
        {
            get => _ApplicationVersion;
            set => SetAndNotify(ref _ApplicationVersion, value);
        }
        private CampaignViewModel _CampaignView;
        public CampaignViewModel CampaignView
        {
            get => _CampaignView;
            set => SetAndNotify(ref _CampaignView, value);
        }
        private Uri _SfxSource;
        public Uri SfxSource
        {
            get => _SfxSource;
            set => SetAndNotify(ref _SfxSource, value);
        }

        // Dropdown Sources
        public List<string> NetArchitectureDifficultyOptions 
        { 
            get
            {
                return new()
                {
                    ReferenceData.NetArchitectureDifficultyBasic,
                    ReferenceData.NetArchitectureDifficultyStandard,
                    ReferenceData.NetArchitectureDifficultyUncommon,
                    ReferenceData.NetArchitectureDifficultyAdvanced
                };
            } 
        }

        // Commands
        public ICommand ProcessKeyboardShortcut => new RelayCommand(DoProcessKeyboardShortcut);
        private void DoProcessKeyboardShortcut(object key)
        {
            switch (key.ToString())
            {
                case "CtrlS":
                    CampaignView.SaveCampaigns.Execute(null);
                    break;
                case "CtrlN":
                    CampaignView.AddCampaign.Execute(null);
                    break;
                default:
                    break;
            }
        }

        


    }
}
