﻿using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class GameNote : BaseModel
    {
        // Constructors
        public GameNote()
        {
            AssociatedNotes = new();
            Name = string.Empty;
            Content = string.Empty;
        }

        // Properties
        private string _Id;
        public string Id
        {
            get => _Id;
            set => SetAndNotify(ref _Id, value);
        }
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _Content;
        public string Content
        {
            get => _Content;
            set => SetAndNotify(ref _Content, value);
        }
        private ObservableCollection<GameNote> _AssociatedNotes;
        public ObservableCollection<GameNote> AssociatedNotes
        {
            get => _AssociatedNotes;
            set => SetAndNotify(ref _AssociatedNotes, value);
        }
        private bool _IsFavorite;
        public bool IsFavorite
        {
            get => _IsFavorite;
            set => SetAndNotify(ref _IsFavorite, value);
        }

        // Commands
        public ICommand AddNewAssociatedNote => new RelayCommand(DoAddNewAssociatedNote);
        private void DoAddNewAssociatedNote(object param)
        {
            GameNote newNote = new();
            newNote.SetNewNoteValues();
            AssociatedNotes.Add(newNote.DeepClone());
            AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes.Add(newNote);
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNote = newNote;
            GameNote copyOfThis = this.DeepClone();
            copyOfThis.AssociatedNotes.Clear();
            newNote.AssociatedNotes.Add(copyOfThis);
            AppData.MainModelRef.CampaignView.ActiveCampaign.UpdateFilteredNotes();
        }
        public ICommand AddAssociations => new RelayCommand(DoAddAssociations);
        private void DoAddAssociations(object param)
        {
            List<GameNote> recordOptions = new();
            foreach (GameNote note in AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes)
            {
                if (note.Id == Id) { continue; } // don't associated with self
                GameNote existingNote = AssociatedNotes.FirstOrDefault(n => n.Id == note.Id);
                if (existingNote == null)
                {
                    GameNote noteToAdd = note.DeepClone();
                    noteToAdd.AssociatedNotes.Clear();
                    recordOptions.Add(noteToAdd);
                }
            }
            MultiObjectSelectionDialog multiAdd = new(recordOptions, AppData.MultiModeAssociatedNotes);
            if (multiAdd.ShowDialog() == true)
            {
                foreach (GameNote note in (multiAdd.DataContext as MultiObjectSelectionViewModel).SelectedNotes)
                {
                    AssociatedNotes.Add(note);
                    GameNote otherNote = AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes.First(n => n.Id == note.Id);
                    GameNote backLink = this.DeepClone();
                    backLink.AssociatedNotes.Clear();
                    otherNote.AssociatedNotes.Add(backLink);
                }
                SortAssociatedNotes();
            }
        }
        public ICommand RemoveNote => new RelayCommand(DoRemoveNote);
        private void DoRemoveNote(object param)
        {
            if (param == null) { return; }
            if (param.ToString() == "Campaign")
            {
                string id = Id;
                AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes.Remove(this);
                foreach (GameNote note in AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes)
                {
                    note.AssociatedNotes = new(note.AssociatedNotes.Where(n => n.Id != id));
                }
                AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNote = null;
                AppData.MainModelRef.CampaignView.ActiveCampaign.UpdateFilteredNotes();
            }
            if (param.ToString() == "Note")
            {
                string otherId = AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNote.Id;
                GameNote otherNote = AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes.First(n => n.Id == Id);
                otherNote.AssociatedNotes = new(otherNote.AssociatedNotes.Where(n => n.Id != otherId));
                AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNote.AssociatedNotes.Remove(this);
            }
        }
        public ICommand GoToNote => new RelayCommand(DoGoToNote);
        private void DoGoToNote(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNote = AppData.MainModelRef.CampaignView.ActiveCampaign.GameNotes.First(n => n.Id == Id);
        }
        public ICommand SortNotes => new RelayCommand(DoSortNotes);
        private void DoSortNotes(object param)
        {
            AssociatedNotes = new(AssociatedNotes.OrderBy(n => n.Type).ThenBy(n => n.Name));
        }
        public ICommand ToggleFavorite => new RelayCommand(DoToggleFavorite);
        private void DoToggleFavorite(object param)
        {
            IsFavorite = !IsFavorite;
        }

        // Public Methods
        public void SetNewNoteValues()
        {
            Id = HelperMethods.GetUniqueId();
            Name = "New Note";
        }

        // Private Methods
        private void SortAssociatedNotes()
        {
            AssociatedNotes = new(AssociatedNotes.OrderBy(n => n.Type).ThenBy(n => n.Name));
        }

    }
}
