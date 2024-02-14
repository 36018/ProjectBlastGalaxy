using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAI : MonoBehaviour
{
    [SerializeField] private Transform player;
    [Range(0.01f, 2f)]
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        player = target;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
