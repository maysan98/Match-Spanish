using System;
using Unity.VisualScripting;
using UnityEngine;

public class Collect : MonoBehaviour
{
    GameManager gm;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.AddFinds();
            Destroy(gameObject);
        }
    }
}
 