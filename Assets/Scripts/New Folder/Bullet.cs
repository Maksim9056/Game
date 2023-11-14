using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnDisable()
    {
        rb.velocity = Vector3.zero; // Сбрасываем скорость пули при отключении
    }

    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>(); // Получаем компонент здоровья у цели
        if (health != null)
        {
            health.TakeDamage(damage);
        }

        gameObject.SetActive(false); // Отключаем пулю при столкновении
    }
}