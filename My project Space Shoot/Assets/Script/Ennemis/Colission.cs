using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{
    public int scoreDestruction = 10;
    public int playerlife = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision Trigger avec " + other.gameObject.name);//nom du GameObject collidé !
        if (other.gameObject.tag == "Missile")
        {
            Debug.Log("Ennemi entre en collision un missile");

            InfosPlayer.Instance.addscore(scoreDestruction);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ennemi entre en collision avec Player");
            
            InfosPlayer.Instance.UpdateLife(-1 * playerlife);
            InfosPlayer.Instance.addscore(scoreDestruction);
            Destroy(this.gameObject);
            
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("ennemi entre en collision avec" + other.gameObject.name);
        

    }
}
