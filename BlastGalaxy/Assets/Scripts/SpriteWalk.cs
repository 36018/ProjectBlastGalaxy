using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteWalk : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}