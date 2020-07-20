namespace Hyperai.Relations
{
    public abstract class RelationModel
    {
        /// <summary>
        /// User number
        /// </summary>
        public long Identity { get; set; }
        /// <summary>
        /// identify a relation model
        /// </summary>
        public abstract string Identifier { get; }
        public override int GetHashCode()
        {
            return Identifier.GetHashCode();
        }
    }
}
