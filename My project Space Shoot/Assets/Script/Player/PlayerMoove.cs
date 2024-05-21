using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoove : MonoBehaviour
{
    float playerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaleDir = Input.GetAxis("Horizontal");
        float verticaleDir = Input.GetAxis("Vertical");
        Vector3 pos = transform.position;
        pos.y += verticaleDir * playerSpeed * Time.deltaTime;
        pos.x += horizontaleDir * playerSpeed * Time.deltaTime;
        transform.position = pos;

    }
}
