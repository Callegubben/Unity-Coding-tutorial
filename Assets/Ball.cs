using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    private float _maxspeed = 10;

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
        if (speed > _maxspeed)
        {
            speed = _maxspeed;
        }
        _rigidbody.position += _direction * (speed * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            _direction.x = -_direction.x;
            speed++;
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            _direction.y = -_direction.y;
        }
    }
    public void Reset()
    {
        gameObject.transform.position = new Vector2(0, 0);
        _direction = Vector2.one;
        speed = 3;
    }
}
