using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Code qui se déclenche lors de la collision
        Debug.Log("Message pour tester la collision");
    }
}
