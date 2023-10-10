using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed = 10f;

    [Range(1, 10)]
    [SerializeField] private float lifetime = 3f;

    private Rigidbody2D bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        bullet.velocity = transform.up * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //ToDo Tell the enemy object to take damage and how much to take
            Destroy(gameObject);
        }
    }
}
