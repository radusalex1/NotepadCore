using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotepadCore.ViewModels
{
    public class HelpViewModel:ObservableObject
    {
        public ICommand HelpCommand { get; }
        /// <summary>
        /// video 5
        /// </summary>
        /// <param name="helpCommand"></param>
        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DisplayAbout);
        }

        private void DisplayAbout()
        {
            //display about;
        }
    }
}
