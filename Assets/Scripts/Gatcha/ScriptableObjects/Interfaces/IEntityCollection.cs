using Gatcha;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityCollection<T> where T : BaseEntity
{
    T GetRandomItemByRarity(EntityRarity entityRarity);
    T GetItem(long baseId);
    List<T> GetAll();
}
