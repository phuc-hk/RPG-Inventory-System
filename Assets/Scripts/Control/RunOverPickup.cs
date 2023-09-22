using GameDevTV.Inventories;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunOverPickup : MonoBehaviour
{
    Pickup pickup;

    private void Awake()
    {
        pickup = GetComponent<Pickup>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickup.PickupItem();
        }      
    }
}
