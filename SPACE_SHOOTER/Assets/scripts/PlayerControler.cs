using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
   float playerSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");   
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaleDir = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += horizontaleDir * playerSpeed * Time.deltaTime;
        transform.position = pos;

        float verticaleDir = Input.GetAxis("Vertical");
        Vector3 poss = transform.position;
        poss.y += verticaleDir * playerSpeed * Time.deltaTime;
        transform.position = poss; 
    }
}
