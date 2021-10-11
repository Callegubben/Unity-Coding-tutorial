using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 2f;

    [SerializeField]
    private Vector2 _direction = Vector2.one;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private CircleCollider2D _collider;


    // Start is called before the first frame update
    void Start()
    {
        if (_rigidbody == false)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        if (_collider == false)
        {
            _collider = GetComponent<CircleCollider2D>();
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.position += _direction * (speed * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            _direction.x = -_direction.x;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            _direction.y = -_direction.y;
        }
    }
}
