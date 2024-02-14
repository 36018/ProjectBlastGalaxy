using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAI : MonoBehaviour
{
    [SerializeField] private float bulletVelocity;
    [SerializeField] private GameObject currentBulletPrefab;
    private Rigidbody2D rb;
    private Vector3 target;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        direction.Normalize ();

        // Adds velocity to the bullet
        rb.velocity = direction * bulletVelocity; 
    }

    public void SetTarget(Vector3 target)
    {
        this.target = target;
        direction = (Vector2)((target - transform.position));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            other.transform.GetComponent<SlimeAI>().Destroy();
            Destroy(gameObject);
        }
    }

}
