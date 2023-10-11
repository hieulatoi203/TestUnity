using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health = 30f;
    public GameObject player;
    public float moveSpeed = 1f;
    public float LineOfSite = 0f;
    Rigidbody2D rb;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg-90f ;
        direction.Normalize();
        movement = direction;
         float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < LineOfSite || Health < 30f)
        {
            rb.rotation = angle;
            moveCharacter(movement);
        }
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        
    }
    public void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction *moveSpeed * Time.fixedDeltaTime));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Health -= 1f;
        }
    }
}
