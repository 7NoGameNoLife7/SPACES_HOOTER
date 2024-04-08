using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMoove : MonoBehaviour
{
    public float speed = 15f;
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime*speed);
        Destroy(this.gameObject, 3f);

    }
}
