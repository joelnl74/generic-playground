using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CharacterScriptableObject), menuName = "�ontent/Entities/CharacterScriptableObject", order = 1)]
public class CharacterScriptableObject : BaseEntity
{
    [SerializeReference] private Sprite _chracterImage;
}
