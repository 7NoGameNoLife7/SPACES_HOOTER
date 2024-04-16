using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnnemyMoove : MonoBehaviour
{
    [SerializeField]
    public float EnnemySpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ennemy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * EnnemySpeed * Time.deltaTime);
      
        Destroy(this.gameObject, 5f);
    }
}
