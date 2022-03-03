using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NotepadCore.Models
{
    public class FormatModel : ObservableObject
    {
        /// <summary>
        /// Text Style.
        /// </summary>
        private FontStyle _style;
        public FontStyle Style
        {
            get { return _style; }
            set
            {
                OnPropertyChanged(ref _style, value);
            }
        }

        /// <summary>
        /// Text weight.
        /// </summary>
        private FontWeight _fontWeight;
        public FontWeight Weight
        {
            get { return _fontWeight; }
            set
            {
                OnPropertyChanged(ref _fontWeight, value);
            }
        }

        /// <summary>
        /// Text Font.
        /// </summary>
        private FontFamily _family;
        public FontFamily Family
        {
            get { return _family; }
            set
            {
                OnPropertyChanged(ref _family, value);
            }
        }

        /// <summary>
        /// Property for text wrapping.
        /// </summary>
        private TextWrapping _wrap;
        public TextWrapping Wrap
        {
            get { return _wrap; }
            set
            {
                OnPropertyChanged(ref _wrap, value);
                isWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        /// <summary>
        /// Text property for text Wrapping when modifing window sizes.
        /// Related to previous property.
        /// </summary>
        private bool _isWrapped;
        public bool isWrapped
        {
            get
            {
                return _isWrapped;
            }
            set
            {
                OnPropertyChanged(ref _isWrapped, value);
            }
        }

        /// <summary>
        ///  Text Size.
        /// </summary>
        private double _size;
        public double Size
        {
            get
            {
                return _size;
            }
            set
            {
                OnPropertyChanged(ref _size, value);
            }
        }



    }
}
