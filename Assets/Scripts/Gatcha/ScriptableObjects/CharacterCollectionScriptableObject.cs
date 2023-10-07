using Gatcha;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CharacterCollectionScriptableObject), menuName = "Çontent/Entities/Collections/CharacterCollectionScriptableObject", order = 1)]
public class CharacterCollectionScriptableObject : ScriptableObject,
    IEntityCollection<CharacterScriptableObject>
{
    [SerializeField] private List<CharacterScriptableObject> _characterScriptableObjects;

    public List<CharacterScriptableObject> GetAll()
    {
        return _characterScriptableObjects;
    }

    public CharacterScriptableObject GetItem(long baseId)
    {
        return _characterScriptableObjects.FirstOrDefault(x => x.Id == baseId);
    }

    public CharacterScriptableObject GetRandomItemByRarity(EntityRarity entityRarity)
    {
        var entityList = _characterScriptableObjects.Where(x => x.entityRarity == entityRarity);

        return entityList.ElementAt(Random.Range(0, entityList.Count()));
    }
}
