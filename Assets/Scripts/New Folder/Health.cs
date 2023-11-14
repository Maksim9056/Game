using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die(); // Если здоровье достигло нуля, вызываем метод смерти
        }
    }

    private void Die()
    {
        // Реализуйте логику смерти объекта, например, вызов анимации или удаление объекта
    }
}
