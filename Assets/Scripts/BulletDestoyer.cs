using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestoyer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Si la balle n'a rien touch�, on la d�truit une fois arriv� trop bas
        if(transform.position.y < -50) Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // S'il y a collision, supprimer la balle
        Destroy(gameObject);
    }
}
