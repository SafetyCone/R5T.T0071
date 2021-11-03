using System;


namespace R5T.T0071
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class WebHost : IWebHost
    {
        #region Static
        
        public static WebHost Instance { get; } = new();

        #endregion
    }
}