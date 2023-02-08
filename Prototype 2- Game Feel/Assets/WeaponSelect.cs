using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public InventoryButton inventory;

    public Hit weaponChoice;

    public void WeaponOneSelect() {
        weaponChoice.weapon = 1;
        inventory.isOpened = false;
    }

    public void WeaponTwoSelect() {
        weaponChoice.weapon = 2;
        inventory.isOpened = false;
    }

    public void WeaponThreeSelect() {
        weaponChoice.weapon = 3;
        inventory.isOpened = false;
    }
}
