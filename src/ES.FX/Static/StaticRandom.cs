using System;

namespace ES.FX.Static
{
    public static class StaticRandom
    {
        /// <summary>
        ///     Returns a static instance of the <see cref="Random"></see> class
        /// </summary>
        public static Random Instance { get; } = new Random();
    }
}