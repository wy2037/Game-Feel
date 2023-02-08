using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public InventoryButton inventory;

    public Hit weaponChoice;
    public GameObject crosshair;
    public CoinSystem coinCount;
    public GameObject[] CoinUI;

    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip[] clips;

    [SerializeField]
    private bool WeaponTwoUnlocked = false, WeaponThreeUnlocked = false;

    public void WeaponOneSelect() {
        crosshair.SetActive(false);
        weaponChoice.weapon = 1;
        inventory.isOpened = false;
    }

    public void WeaponTwoSelect() {
        if (WeaponTwoUnlocked) {
            crosshair.SetActive(true);
            weaponChoice.weapon = 2;
            inventory.isOpened = false;
        } else {
            if (coinCount.coins > 250) {
                crosshair.SetActive(true);
                coinCount.SpendCoins(250);
                source.PlayOneShot(clips[0]);
                WeaponTwoUnlocked = true;
                weaponChoice.weapon = 2;
                inventory.isOpened = false;
                CoinUI[0].SetActive(false);
                CoinUI[1].SetActive(false);
            } else {
                source.PlayOneShot(clips[1]);
            }
        }
    }

    public void WeaponThreeSelect() {
        if (WeaponThreeUnlocked) {
            crosshair.SetActive(false);
            weaponChoice.weapon = 3;
            inventory.isOpened = false;
        } else {
            if (coinCount.coins > 500) {
                crosshair.SetActive(false);
                coinCount.SpendCoins(500);
                source.PlayOneShot(clips[0]);
                WeaponThreeUnlocked = true;
                weaponChoice.weapon = 3;
                inventory.isOpened = false;
                CoinUI[2].SetActive(false);
                CoinUI[3].SetActive(false);
            } else {
                source.PlayOneShot(clips[1]);
            }
        }
    }
}
