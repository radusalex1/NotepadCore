namespace NotepadCore.Models
{
    public class DocumentModel : ObservableObject
    {
        public string _text;
        /// <summary>
        /// Actual content of document.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set => OnPropertyChanged(ref _text, value);
        }

        /// <summary>
        /// Filepath.
        /// </summary>
        public string _filePath;
        public string FilePath
        {
            get{return _filePath;}
            set => OnPropertyChanged(ref _filePath, value);
        }

        /// <summary>
        /// FileName
        /// </summary>
        public string _fileName;
        public string FileName
        {
            get { return _fileName;}
            set => OnPropertyChanged(ref _fileName, value);
        }

        public bool isEmpty
        {
            get
            {
                if(string.IsNullOrEmpty(FileName) ||
                   string.IsNullOrEmpty(FilePath))

                {
                    return true;
                }
                return false;
            }
        }
    }
}
