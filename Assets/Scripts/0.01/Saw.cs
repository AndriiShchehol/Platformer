using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : Entity
{
    private Vector3 dir;
    private float speed = 2f;
    private SpriteRenderer sprite;

    /*[SerializeField] private gameObject[] points;
    private int currentPointIndex = 0;
    [SerializeField] private float speed = 2f;*/

    private void Start()
    {
        dir = transform.right;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        /*if (Vector2.Distance(points[CurrentPointIndex].transform.position, transform.position) < .1f) // distance between points        
        {
            CurrentPointIndex++;            
            if (CurrentPointIndex >= points.Length)
            {                
                CurrentPointIndex = 0;
            }        
        }
        transform.position = Vector2.MoveTowards(transform.position, points[CurrentPointIndex].transform.position, Time.deltaTime * speed); */   

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f); // checking if direction is available 

        if (colliders.Length > 0) dir *= -1f; // direction change

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime); // moving saw
        
    }

//     private void OnCollisionEnter2D(Collision2D collision)
//    {
//         if (collision.gameObject == Hero.Instance.gameObject)
//         {
//             Hero.Instance.GetDamage();
//         }
//    }
}