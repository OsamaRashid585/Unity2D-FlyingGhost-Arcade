using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float _flyPower;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _rb.AddForce(Vector2.up * _flyPower, ForceMode2D.Impulse);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance._score++;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hurddle"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
