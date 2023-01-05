namespace OHCE
{
    public interface ILangue
    {
        //string Langue { get; set; }
        internal string BienDit { get; }
        string DireBonjour(PériodeJournée période);
        string AuRevoir { get; }
    }
}
