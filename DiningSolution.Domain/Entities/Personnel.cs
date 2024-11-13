
using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Domain.Entities
{
    internal class Personnel
    {
        public int PersonnelID { get; private set; }
        public PersonnelName PersonnelName { get; private set; }
        public string PersonnelPosition { get; private set; }
    }
}
