using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CharacterScriptableObject), menuName = "Çontent/Entities/CharacterScriptableObject", order = 1)]
public class CharacterScriptableObject : BaseEntity
{
    [SerializeReference] private Sprite _chracterImage;
}
