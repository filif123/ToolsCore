using Microsoft.Pex.Framework;

namespace System.Drawing
{
    /// <summary>A factory for System.Drawing.Graphics instances</summary>
    public static class GraphicsFactory
    {
        /// <summary>A factory for System.Drawing.Graphics instances</summary>
        [PexFactoryMethod(typeof(Graphics))]
        public static IDisposable Create()
        {
            Image i = new Bitmap(100, 100);
            return Graphics.FromImage(i);
        }
    }
}
