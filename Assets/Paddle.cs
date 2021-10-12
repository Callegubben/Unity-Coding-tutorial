using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public string player;
    public float speed = 13f;
    private float _verticalDirection;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private BoxCollider2D _collider;

    void Start()
    {
        if (_rigidbody == false)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        if (_collider == false)
        {
            _collider = GetComponent<BoxCollider2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        _verticalDirection = Input.GetAxis($"{player}Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody.position += new Vector2(0, _verticalDirection) * (speed * Time.deltaTime);
    }

}
