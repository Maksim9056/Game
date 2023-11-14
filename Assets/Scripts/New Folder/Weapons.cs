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
    public CameraShake cameraShake; // ������ �� ���������, ���������� �� ������ ������

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
            cameraShake.Shake(); // ���������� ������ ������
        }
    }

    private void Shoot()
    {
        GameObject bullet = ObjectPooler.Instance.GetPooledObject(); // �������� ���� �� ���� ��������
        if (bullet != null)
        {
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true);

            currentAmmo--;
        }
    }
}
