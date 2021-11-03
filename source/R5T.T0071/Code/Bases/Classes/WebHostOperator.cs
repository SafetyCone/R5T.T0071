using System;


namespace R5T.T0071
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class WebHostOperator : IWebHostOperator
    {
        #region Static
        
        public static WebHostOperator Instance { get; } = new();

        #endregion
    }
}