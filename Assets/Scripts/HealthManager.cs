using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public PlayerController thePlayer;
    public float invincibilityLength;
    private float invincibilityCounter;
    public Renderer playerRenderer;
    public Renderer playerRendererSpikes;
    private float flashCounter;
    public float flashLength=0.1f;

    private bool isRespawning;
    private Vector3 respawnPoint;
    public float respawnLength;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
        //thePlayer = FindObjectOfType<PlayerController>();
        respawnPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(invincibilityCounter>0)
        {
            invincibilityCounter-=Time.deltaTime;

            flashCounter-=Time.deltaTime;

            if(flashCounter<=0)
            {
                playerRenderer.enabled = !playerRenderer.enabled;
                playerRendererSpikes.enabled=!playerRendererSpikes.enabled;
                flashCounter=flashLength;
            }

            if(invincibilityCounter<=0){
                playerRenderer.enabled=true;
                playerRendererSpikes.enabled=true;
            }
        }
    }
    
    public void HurtPlayer(int damage, Vector3 direction)
    {
        if(invincibilityCounter<=0)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                respawn();
            }
            else
            {

                thePlayer.Knockback(direction);

                invincibilityCounter = invincibilityLength;

                playerRenderer.enabled = false;
                playerRendererSpikes.enabled = false;

                flashCounter = flashLength;
            }
        }
        
    }
    public void respawn()
    {
        //thePlayer.transform.position = respawnPoint;
        //currentHealth = maxHealth;
        if (!isRespawning)
        {


            StartCoroutine("RespawnCo");
        }
    }
    public IEnumerator Respawnco()
    {
        isRespawning = true;
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnLength);
        isRespawning = false;
        thePlayer.gameObject.SetActive(true);
        currentHealth = maxHealth;

    }
    public void HealPlayer(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            invincibilityCounter = invincibilityLength;

            playerRenderer.enabled = false;
            playerRendererSpikes.enabled = false;

            flashCounter = flashLength;
        }
    }
}
