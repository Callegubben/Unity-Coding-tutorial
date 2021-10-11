using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    float horizontal;
    float vertical;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    public Vector2 movementDirection;


    // Start is called before the first frame update
    void Start()
    {
        if (_rigidbody == false)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
       // print($"{vertical}, { horizontal}");
        movementDirection = new Vector2(horizontal, vertical);
     }

    private void FixedUpdate()
    {
        /*
        if (movementDirection.x < 0)
        {
            gameObject.transform.Rotate(0, 180, 0);
        }
        else if (movementDirection.x > 0)
        {
            gameObject.transform.Rotate(0, -180, 0);
        }
        */
        _rigidbody.position += movementDirection * speed * Time.deltaTime;

    }
}
