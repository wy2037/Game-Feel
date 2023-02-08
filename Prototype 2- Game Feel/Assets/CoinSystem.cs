using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int coins = 0;

    public void GainCoins(int amount) {
        coins += amount;
    }

    public void SpendCoins(int amount) {
        coins -= amount;
    }

    void Update() {
        coinText.text = coins.ToString();
    }
}
