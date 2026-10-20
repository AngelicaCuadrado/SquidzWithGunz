using UnityEngine;
using Unity.Netcode;

public class PlayerHealthComponent : NetworkBehaviour
{
    NetworkVariable<float> currentHealth;
    NetworkVariable<float> maxHealth;

    void Heal(float value) 
    {
        if (!IsServer) return;
        currentHealth.Value = currentHealth.Value + value < maxHealth.Value ? currentHealth.Value + value : maxHealth.Value;
    }

    void TakeDamage(float value) 
    {
       if (!IsServer) return;
       currentHealth.Value = Mathf.Max(0, currentHealth.Value - value);
        if (currentHealth.Value == 0) Die();
    }

    void Die()
    {
        Debug.Log("A Player Has Died");
    }
  
    void Start() 
    {
      
    }

    
    void Update()
    {
        
    }
}
