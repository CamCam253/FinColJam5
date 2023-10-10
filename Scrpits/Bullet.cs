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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log($"{collision.transform.tag} - {collision.transform.name}");
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy eScript = collision.gameObject.GetComponent<Enemy>();
            if (eScript != null)
            {
                eScript.takeDamage(1);
                Destroy(gameObject);
            }
        }
    }
}
