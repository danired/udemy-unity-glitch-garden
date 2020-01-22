using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    float defaultDamage = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;

        if (otherObject.GetComponent<Attacker>())
        {
            HealthDisplay healthDisplay = FindObjectOfType<HealthDisplay>();
            healthDisplay.DealDamage(defaultDamage);
            Destroy(otherObject);
        }
    }
}
