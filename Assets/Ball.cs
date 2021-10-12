using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 550f;

    [SerializeField]
    private Vector2 _direction;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private CircleCollider2D _collider;


    // Start is called before the first frame update
    void OnEnable()
    {
        if (_rigidbody == false)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        if (_collider == false)
        {
            _collider = GetComponent<CircleCollider2D>();
        }
        float x = Random.Range(-1, 1);
        while (x == 0)
        {
            x = Random.Range(-1, 1);
        }
        float y = Random.Range(-0.5f, 0.5f);
        while (y == 0)
        {
            y = Random.Range(-0.5f, 0.5f);
        }

        _direction = new Vector2(x, y);

        _rigidbody.AddForce(_direction * speed);
    }
    /*
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
    }*/
    public void Reset()
    {
        gameObject.transform.position = new Vector2(0, 0);
        _rigidbody.velocity = new Vector2(0, 0);
        OnEnable();
    }
}
