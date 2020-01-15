using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;

        Attacker attacker = otherObject.GetComponent<Attacker>();
        if (attacker)
        {
            // ...
        }
    }
}
