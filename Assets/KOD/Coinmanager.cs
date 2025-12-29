using System;
using Unity.VisualScripting;
using UnityEngine;

public class Coinmanager : MonoBehaviour
{
    [SerializeField] int puanMiktari=5;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<HealthController>().puanAl(puanMiktari);
            Destroy(gameObject);
        }
    }
}
