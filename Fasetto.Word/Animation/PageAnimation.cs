namespace Fasetto.Word
{
    /// <summary>
    /// Styles of page animations for appearing/disappearing
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// No animation takes place
        /// </summary>
        None = 0,

        /// <summary>
        /// The page slides in and fades in from the right
        /// </summary>
        SlideAndFadeInFromRight,

        /// <summary>
        /// The page slides in and fades in from the left
        /// </summary>
        SlideAndFadeOutToLeft
    }
}
