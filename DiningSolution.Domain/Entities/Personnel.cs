using DiningSolution.Domain.ValueObjects;

namespace DiningSolution.Domain.Entities
{
    public class Personnel
    {
        public Personnel(PersonnelID personnelID, PersonnelName personnelName, PersonnelPosition personnelPosition)
        {
            PersonnelID = personnelID;
            PersonnelName = personnelName;
            PersonnelPosition = personnelPosition;
        }

        public PersonnelID PersonnelID { get; private set; }
        public PersonnelName PersonnelName { get; private set; }
        public PersonnelPosition PersonnelPosition { get; private set; }

        public static Personnel Create(PersonnelID personnelID, PersonnelName personnelName, PersonnelPosition personnelPosition)
        {
            return new Personnel(personnelID, personnelName, personnelPosition);
        }
    }
}
