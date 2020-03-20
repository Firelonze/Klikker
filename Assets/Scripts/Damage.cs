using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Damage : MonoBehaviour
{
    [SerializeField] public GameObject camShake;
    [SerializeField]
    public void Clicked()
    {
        var hPoints = GetComponent<Health>();
        hPoints.ChangeHealth();
    }
}

