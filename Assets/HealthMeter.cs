using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthMeter : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    [SerializeField] private UnityEvent onDeath;
    [SerializeField] private UnityEvent onHealthChange;
    [SerializeField] private UnityEvent onHealthIncrease;
    [SerializeField] private UnityEvent onHealthDecrease;
    private int currentHealth;

    public void AddHealth(int amount)
    {
        currentHealth += amount;
        onHealthChange.Invoke();

        if (amount >= 0)
            onHealthIncrease.Invoke();
        else
            onHealthDecrease.Invoke();
        
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
            
        if (currentHealth <= 0)
            currentHealth = 0;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }
     

    void Update()
    {
        
    }
}
