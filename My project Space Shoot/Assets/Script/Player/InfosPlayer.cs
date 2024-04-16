using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfosPlayer : MonoBehaviour
{
    public static InfosPlayer Instance;
    public int score = 0;
    public int life = 3;
    private void Awake()
    {
        Instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        IHM.Instance.UpdateScore();
        IHM.Instance.UpdateLife();
    }

    // Update is called once per frame
    public void addscore(int value)
    {
        score += value;

        Debug.Log("Score actuel du player" + score);
        IHM.Instance.UpdateScore();
        IHM.Instance.UpdateLife();
    }
    public void UpdateLife(int value)
    {
        life += value;
        IHM.Instance.UpdateLife();
        if (life <= 0) 
        {
            IHM.Instance.DisplayGameOverMenu(true);
            
        }
    }
}
