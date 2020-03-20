using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float healthPoints = 200;
    [SerializeField] private Text hpText;
    void Start()
    {
        hpText.text = "Hp enemy: " + healthPoints;
    }
    [SerializeField]public void ChangeHealth()
    {
        healthPoints -= Mathf.Round(Random.Range(1f, 10f));
        Invoke("ChangeText", 1);
    }
    void ChangeText()
    {
        hpText.text = "Hp enemy: " + healthPoints;
    }
}
