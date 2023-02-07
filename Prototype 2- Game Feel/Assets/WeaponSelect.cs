using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public Hit weaponChoice;

    public void WeaponOneSelect() {
        weaponChoice.weapon = 1;
    }

    public void WeaponTwoSelect() {
        weaponChoice.weapon = 2;
    }

    public void WeaponThreeSelect() {
        weaponChoice.weapon = 3;
    }

    public void WeaponFourSelect() {
        weaponChoice.weapon = 4;
    }
}
