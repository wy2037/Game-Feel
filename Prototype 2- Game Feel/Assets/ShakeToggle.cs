using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakeToggle : MonoBehaviour
{
    public Shake cameraShake;
    public Toggle thisToggle;

    // Update is called once per frame
    void Update()
    {
        cameraShake.shakeToggle = thisToggle.isOn;
    }
}
