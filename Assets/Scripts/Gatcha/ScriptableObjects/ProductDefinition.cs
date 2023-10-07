using Gatcha;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class  ProductEntity
{
    public float Chance;
    public BaseEntity Entity;
}

[CreateAssetMenu(fileName = nameof(ProductDefinition), menuName = "Çontent/Entities/Collections/ProductDefinition", order = 1)]
public class ProductDefinition : ScriptableObject
{
    public long Id;
    public long BalanceId;

    public string Name;
    public int Cost;

    public Sprite _productSprite;
    
    [SerializeField] private List<ProductEntity> _productList;
    [SerializeField] private List<BaseEntity> _entitiesOdds = new List<BaseEntity>();

    private void OnValidate()
    {
        CalculateOdds();
    }

    public List<BaseEntity> GetRandomPulls(int amount)
    {
        var entities = new List<BaseEntity>();

        for (var i = 0; i < amount; i++)
        {
            var entity = _entitiesOdds.ElementAt(UnityEngine.Random.Range(0, _entitiesOdds.Count()));
            entities.Add(entity);
        }

        return entities;
    }

    private void CalculateOdds()
    {
        _entitiesOdds.Clear();

        for (var i = 0; i < _productList.Count; i++)
        {
            var productEntity = _productList[i];
            // note that odds are based on percentages set in the product for now.
            var amountInPool = productEntity.Chance * 100;

            AddToPool(productEntity.Entity, (int)amountInPool);
        }
    }

    private void AddToPool(BaseEntity baseEntity, int amount)
    {
        for (var i = 0; i < amount; i++) 
        {
            _entitiesOdds.Add(baseEntity);
        }
    }
}
