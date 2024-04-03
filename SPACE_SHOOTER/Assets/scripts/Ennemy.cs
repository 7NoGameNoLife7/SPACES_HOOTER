using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + (Vector3.down*Time.deltaTime*10));
        //  transform.Translate(Vector2.down * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Code qui se déclenche lors de la collision
        Debug.Log("Message pour tester la collision");
    }
}