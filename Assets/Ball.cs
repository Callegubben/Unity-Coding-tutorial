using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 2f;
    private float _maxSpeed = 20;

    [SerializeField]
    private Vector2 _direction;

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
        _direction = Vector2.right;
        _direction += Vector2.up;

    }

    private void FixedUpdate()
    {
        _rigidbody.position += Vector2.right * (speed * Time.fixedDeltaTime);

    }
}
