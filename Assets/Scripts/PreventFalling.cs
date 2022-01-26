using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventFalling : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Pour eviter que le personnage ne tombe, on fixe sa hauteur
        if (transform.position.y < 1.5) transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);
    }
}
