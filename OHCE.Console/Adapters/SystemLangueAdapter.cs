namespace OHCE.Console.Adapters
{
    internal class SystemLangueAdapter : ILangue
    {
        /// <inheritdoc />
        public string BienDit { get; }

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée période)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string AuRevoir { get; }
    }
}
