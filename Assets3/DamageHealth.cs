using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHealth : MonoBehaviour
{
    void OnTriggerEnter2d(Collider2d col)
    {
        HealthBarScript.health -= 10f;
    }
}
