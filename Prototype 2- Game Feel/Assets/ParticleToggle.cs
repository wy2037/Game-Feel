using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleToggle : MonoBehaviour
{
    public Health particleSystem;
    public Toggle thisToggle;

    // Update is called once per frame
    void Update()
    {
        particleSystem.particleToggle = thisToggle.isOn;
    }
}