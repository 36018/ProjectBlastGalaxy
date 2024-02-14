using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform parent;
    [SerializeField] private float cooldown;
    private bool canShoot;

    void Start()
    {
        Physics.IgnoreLayerCollision(6, 7);
        canShoot = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            SpawnBulletOnClick();
            StartCoroutine(Cooldown());
        }
        
    }

    IEnumerator Cooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }

    void SpawnBulletOnClick()
    {
        float x = 0;
        float y = 0;

        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject newBullet = Instantiate(bullet, pos, transform.rotation);
        newBullet.transform.SetParent(parent);
        newBullet.GetComponent<BulletAI>().SetTarget(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
