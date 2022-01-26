using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject spawningFrom;
    [SerializeField] private float speed = 1000f;
    [SerializeField] private float bulletPerSecond = 10f;
    bool canShoot = true;

    void spawnBullet()
    {
        // Si le cooldown pour tirer n'est pas passé, on ne fait rien
        if (!canShoot) return;

        // Sinon on crée une balle et on lui applique une force
        GameObject bullet = Instantiate(bulletPrefab, spawningFrom.transform.position, Quaternion.identity, parent.transform);
        bullet.GetComponent<Rigidbody>().AddForce(spawningFrom.transform.forward * speed);
        canShoot = false;
    }

    IEnumerator bulletCooldown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1/bulletPerSecond);
            canShoot = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(nameof(bulletCooldown));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) spawnBullet();
    }
}
