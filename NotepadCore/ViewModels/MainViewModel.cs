using NotepadCore.Models;

namespace NotepadCore.ViewModels
{
    public class MainViewModel
    {
        /// <summary>
        /// Document that is saved, loaded and hold editor text.
        /// </summary>
        private DocumentModel _document;

        /// <summary>
        /// Manages user input fopr document and format styles.
        /// </summary>
        public  EditorViewModel Editor { get; set; }

        /// <summary>
        /// Manages saving and loading tet files.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Manage help dialog.
        /// </summary>
        public HelpViewModel Help { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }



    }
}
