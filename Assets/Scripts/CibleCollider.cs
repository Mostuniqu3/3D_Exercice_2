using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleCollider : MonoBehaviour
{
    [SerializeField] private float range = 10f;

    private void OnCollisionEnter(Collision collision)
    {   
        // On TP la cible a un autre endroit parmi la range
        transform.position = new Vector3(Random.Range(-range, range), Random.Range(1, 3), Random.Range(-range, range));
    }

}

