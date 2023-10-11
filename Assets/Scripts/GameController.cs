using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Enemy;
    public float SpawnTime = 2f;
    float m_spawn;
    // Start is called before the first frame update
    void Start()
    {
        m_spawn=0 ;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawn -= Time.deltaTime;
        if(m_spawn < 0)
        {
            Spawn();
            m_spawn = SpawnTime;
        }
    }
    void Spawn()
    {
        float PosX = Random.Range(-9f, 9f);
        Vector2 spawnPos = new Vector2(PosX, 9);
        Instantiate(Enemy, spawnPos, Quaternion.identity);
    }
}
