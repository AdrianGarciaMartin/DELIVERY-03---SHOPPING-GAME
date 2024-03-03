using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory System/Items/Weapons")]
public class ItemWeapons : ConsumableItem
{
    public int ItemWeapon;

    public override void Use(IConsume consumer)
    {
        consumer.UseWeapon(this);
    }
}