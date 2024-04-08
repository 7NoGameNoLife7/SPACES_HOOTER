using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ennemi entre en collision avec" + other.gameObject.name);

        if (other.gameObject.tag == "Missile")
        {
            Debug.Log("Ennemi entre en collision un missile");

            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
