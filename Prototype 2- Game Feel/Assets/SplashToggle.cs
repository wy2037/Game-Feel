using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashToggle : MonoBehaviour
{
    public Health enemy;
    private GameObject[] splashes;
    public Toggle thisToggle;

    void Update() {
        enemy.splashToggle = thisToggle.isOn;
        if (enemy.splashToggle == false) {
            splashes = GameObject.FindGameObjectsWithTag("Splash");

            foreach (GameObject splash in splashes) {
                splash.GetComponent<Lifetime>().Clean();
            }
        }
    }
}
