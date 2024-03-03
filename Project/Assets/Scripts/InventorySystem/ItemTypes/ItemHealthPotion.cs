using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory System/Items/HealthPotion")]
public class ItemHealthPotion : ConsumableItem
{
    public int HealthPoints = 5;
    public int _cost = 15;

    public override void Use(IConsume consumer)
    {
        consumer.Use(this);
    }
}
