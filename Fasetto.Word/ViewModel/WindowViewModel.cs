using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// The View Model for the custom Window Styling
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window _mWindow;


        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        private int _mOuterMarginSize = 10;


        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        private int _mWindowRadius = 10;
        #endregion

        #region Public Properties
        
        public string Test { get; set; } = "My string";
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public WindowViewModel(Window window)
        {

        }
        #endregion
    }
}
