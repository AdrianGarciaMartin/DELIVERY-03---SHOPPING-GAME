using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory System/Items/Food")]
public class ItemFood : ConsumableItem
{
    public int _healthPoints = 5;
    public int _cost = 20;

    public override void Use(IConsume consumer)
    {
        consumer.Use(this);
    }

}
