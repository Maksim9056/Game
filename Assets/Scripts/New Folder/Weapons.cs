using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Weapons : MonoBehaviour
{
    public int maxAmmo = 10;
    public float fireRate = 1f;
    public int damage = 1;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public CameraShake cameraShake; // Ссылка на компонент, отвечающий за тряску камеры

    private float nextFireTime;
    private int currentAmmo;

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime && currentAmmo > 0)
        {
            nextFireTime = Time.time + 1f / fireRate;
            Shoot();
            cameraShake.Shake(); // Активируем тряску камеры
        }
    }

    private void Shoot()
    {
        GameObject bullet = ObjectPooler.Instance.GetPooledObject(); // Получаем пулю из пула объектов
        if (bullet != null)
        {
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true);

            currentAmmo--;
        }
    }
}
