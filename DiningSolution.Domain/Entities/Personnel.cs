using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Domain.Entities
{
    internal class Personnel
    {
        public PersonnelID PersonnelID { get; private set; }
        public PersonnelName PersonnelName { get; private set; }
        public PersonnelPosition PersonnelPosition { get; private set; }
    }
}
