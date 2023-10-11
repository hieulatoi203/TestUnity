using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public Transform player;
    public GameObject shootingPointLeft;
    public GameObject shootingPointRight;
    public GameObject bulletPrefab;
    public float SpawnTime = 1f;
    float m_spawnTime;

    private void Start()
    {
        m_spawnTime = 2;
    }
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if(m_spawnTime < 0)
        {
            ShootLeft();
            ShootRight();
            m_spawnTime = SpawnTime;
        }
    }
    void ShootLeft()
    {
        Instantiate(bulletPrefab, shootingPointLeft.transform.position, shootingPointLeft.transform.rotation);
    }
    void ShootRight()
    {
        Instantiate(bulletPrefab, shootingPointRight.transform.position, shootingPointRight.transform.rotation);
    }
}
