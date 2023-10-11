using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shoottingPointLeft;
    public Transform shootingPointRight;
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public float bulletForce =20f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetMouseButtonDown(1))
        {
            ShootRight();
        }
    }
    public void Shoot()
    {
        GameObject bullets = Instantiate(bulletPrefab,shoottingPointLeft.position, shoottingPointLeft.rotation);
        Rigidbody2D rb = bullets.GetComponent<Rigidbody2D>();
        rb.AddForce(shoottingPointLeft.up* bulletForce, ForceMode2D.Impulse);
    }
    public void ShootRight()
    {
        GameObject bullets = Instantiate(bulletPrefab2, shootingPointRight.position, shootingPointRight.rotation);
        Rigidbody2D rb = bullets.GetComponent<Rigidbody2D>();
        rb.AddForce(shootingPointRight.up * bulletForce, ForceMode2D.Impulse);
    }
}

