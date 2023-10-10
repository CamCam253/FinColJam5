using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleEnemy : MonoBehaviour
{
    private SpriteRenderer invis;
    //Tätä voi käyttää tagin sijaan
    [SerializeField] GameObject scanner;
    //jokin kutsuisi tietoa upgradesta jolla näkymättömät näkee aina

    // Start is called before the first frame update
    void Start()
    {
        invis = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scanner" || collision.gameObject == scanner) 
        {
            invis.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scanner" || collision.gameObject == scanner)
        {
            invis.enabled = false;
        }
    }
}
