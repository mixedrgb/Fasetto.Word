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
        

        /// <summary>
        /// The size of the resize border around the window.
        /// </summary>
        public int ResizeBorder { get; set; } = 6;


        /// <summary>
        /// The size of the resize border around the window, taking into account the outer margin.
        /// Resizes the window's border thickness. See <see cref="ResizeBorder">ResizeBorder</see>.
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder); } }


        /// <summary>
        /// Get the value of the outer margin size. See <see cref="_mOuterMarginSize">_mOuterMarginSize</see>.
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return _mWindow.WindowState == WindowState.Maximized ? 0 : _mOuterMarginSize;
            }
            set
            {
                _mOuterMarginSize = value;
            }
        }


        /// <summary>
        /// The thickness of the outer margin. See <see cref="OuterMarginSize">OuterMarginSize</see>.
        /// </summary>
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }


        /// <summary>
        /// Gets the radius value of the edges of the window. See <see cref="_mWindowRadius">_mWindowRadius</see>.
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return _mWindow.WindowState == WindowState.Maximized ? 0 : _mWindowRadius;
            }
            set
            {
                _mWindowRadius = value;
            }
        }


        /// <summary>
        /// The corner radius of the edges of the window
        /// </summary>
        public CornerRadius  WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            _mWindow= window;

            // Listen for the window resizing.
            _mWindow.StateChanged += (sender, e) =>
            {
                // Event for all properties that are affected by a resize.
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
        }
        #endregion
    }
}
