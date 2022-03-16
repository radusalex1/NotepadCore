using Microsoft.Win32;
using NotepadCore.Models;
using System.IO;
using System.Windows.Input;

namespace NotepadCore.ViewModels
{
    public class FileViewModel
    {
        public DocumentModel Document { get; private set; }

        /// <summary>
        /// Comands in nav bar.
        /// </summary>
        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="document"></param>
        /// <param name="newCommand"></param>
        /// <param name="saveCommand"></param>
        /// <param name="saveAsCommand"></param>
        /// <param name="openCommand"></param>
        public FileViewModel(DocumentModel document)
        {
            Document = document;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile, () => !Document.isEmpty);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);

        }

        public void NewFile()
        {
            Document.FileName = string.Empty;
            Document.FilePath = string.Empty;
            Document.Text = string.Empty;
        }

        private void SaveFile()
        {
            if(Document.FilePath == null)
            {
                SaveFileAs();
            }
            else
            {
                File.WriteAllText(Document.FilePath, Document.Text);

            }
        }

        public void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Document.Text);
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                Document.Text= File.ReadAllText(openFileDialog.FileName);
                DockFile(openFileDialog);
            }
        }

        /// <summary>
        /// It is called when you want to open a file or save a file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dialog"></param>
       private void DockFile<T>(T dialog) where T : FileDialog
       {
            Document.FilePath = dialog.FileName;
            Document.FileName = dialog.SafeFileName;
       }
    }
}
