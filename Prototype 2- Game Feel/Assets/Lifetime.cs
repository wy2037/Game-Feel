using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public void Clean()
    {
        Destroy(gameObject);
    }
}
