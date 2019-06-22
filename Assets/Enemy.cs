using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int MaxHealth = 4;
    int currHealth;
    public GameObject DeathFX;
    Score currScore;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = MaxHealth;
        currScore = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currHealth==0)
        {
            
            Instantiate(DeathFX, transform.position,Quaternion.identity);
            currScore.UpdateScore(MaxHealth * 25);
            Destroy(gameObject);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        currHealth--;
        currHealth = Mathf.Clamp(currHealth, 0, MaxHealth);
        
    }
}
