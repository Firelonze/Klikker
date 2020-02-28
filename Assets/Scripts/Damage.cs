using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Damage : MonoBehaviour
{
    float health;
    float damage;
    bool isDead;
    [SerializeField] Button player;
    [SerializeField]Text textHp;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            var colors = GetComponent<Button>().colors;
            colors.normalColor = Color.gray;
            GetComponent<Button>().colors = colors;
            isDead = true;
            textHp.text = "dead";
        }
        else
        {
            textHp.text = "HP : " + health.ToString();
        }
        damage = Mathf.Round(Random.Range(0f, 10f));
    }
    public void TakeDamage()
    {
        health -= damage;
    }
}
