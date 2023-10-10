using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform target;
    public float speed = 3f;
    int health = 1;
    void Start()
    {
        GameSystem.enemyAmount++;
        target = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if (health <= 0)
        {
            death();
        }
    }
    void death()
    {
        GameObject.Destroy(gameObject);
        GameSystem.enemyAmount--;
    }
    public void takeDamage(int amount)
    {
        health = health - amount;
    }
}
