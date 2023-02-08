using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public Camera cam;
    public Toggle thisToggle;

    void Update() {
        cam.GetComponent<AudioListener> ().enabled = thisToggle.isOn;
    }
}
