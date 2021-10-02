using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive = 1;
   
    
    public AudioSource CollideSound;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CollideSound.Play();
            Vector3 hitDirection =
                other.transform.position - transform.position;
            hitDirection = hitDirection.normalized;
            GoldPickup.score -= 1;
       
            Debug.Log(GoldPickup.score);
            OnUpdate(GoldPickup.score);
            //OnUpdate(GoldPickup.score);
            
            FindObjectOfType<HealthManager>()
                .HurtPlayer(damageToGive, hitDirection);
        }
    }

    /*void OnEnable()
    {
        //subscribe to event
        GoldPickup.OnUpdate += ScoreChange;
    }*/

    // void OnDisable()
    // {
    //     //Un-subscribe to event
    //     GoldPickup.OnUpdate -= ScoreChange;
    // }

    //This will be called when invoked
    /*void ScoreChange(int score)
    {
        score-=1;
        //Debug.Log(score);
    }*/
}
