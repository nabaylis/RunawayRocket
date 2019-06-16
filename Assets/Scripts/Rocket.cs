using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed;
    public float drift;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector2.right * drift * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector2.left * drift * Time.deltaTime);
        }

    }
}
