using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public float speed = 550f;
    public bool reset = true;
    public string gamemode;

    [SerializeField]
    private Text _countdownText;

    [SerializeField]
    private Vector2 _direction;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private CircleCollider2D _collider;

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
        if (gamemode == "Pong")
        {
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
            if (reset)
            {
                StartCoroutine(waiter());
            }
        }
        else if (gamemode == "BlockBreaker")
        {
            float x = Random.Range(-1, 1);
            while (x == 0)
            {
                x = Random.Range(-1, 1);
            }
            float y = Random.Range(0, 1f);
            while (y == 0)
            {
                y = Random.Range(0, 1f);
            }
            _direction = new Vector2(x, y);
            if (reset)
            {
                StartCoroutine(waiter());
            }
        }
    }

    public void Reset()
    {
        gameObject.transform.position = new Vector2(0, 0);
        _rigidbody.velocity = new Vector2(0, 0);
        OnEnable();
    }

    IEnumerator waiter()
    {
        _countdownText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        _countdownText.text = "2";
        yield return new WaitForSecondsRealtime(1);
        _countdownText.text = "1";
        yield return new WaitForSecondsRealtime(1);
        _countdownText.gameObject.SetActive(false);
        _countdownText.text = "3";
        _rigidbody.AddForce(_direction * speed);
    }
}
