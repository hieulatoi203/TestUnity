using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject hitEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
