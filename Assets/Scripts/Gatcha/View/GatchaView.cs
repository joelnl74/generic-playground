using Core.UI;
using Core.View;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatchaView : BaseView
    , IGatchaView
{
    [SerializeField] public UIButton _button;

    public void DidComplete()
    {
        Debug.Log("Did complete");
    }

    public void DidLoadData(BaseEntity baseEntity)
    {
        Debug.Log($"Received entity{baseEntity.Id} rarity: {baseEntity.entityRarity}");
    }
}
