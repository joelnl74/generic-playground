namespace Gatcha
{
    public enum EntityType
    {
        None,
        Character,
        Weapon
    }

    public enum EntityRarity
    {
        None,
        Normal,
        Rare,
        Epic,
        Legendary
    }

    public class Entity
    {
        public long Id;
        // Refers to the base id for a weapon or character.
        public long BaseId;
        public EntityType entityType;
        public EntityRarity entityRarity;
    }

}
