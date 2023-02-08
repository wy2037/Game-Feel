using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnToggle : MonoBehaviour
{
    public Health respawn;
    public Toggle thisToggle;

    // Update is called once per frame
    void Update()
    {
        if (thisToggle.isOn) {
            respawn.respawnTimer = 0;
        } else {
            respawn.respawnTimer = 5;
        }
    }
}
