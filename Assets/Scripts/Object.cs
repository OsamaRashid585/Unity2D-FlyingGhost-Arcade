using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private float _moveSpeed = 9f;
    private void Update()
    {
        transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("OffsetDestroy"))
        {
            Destroy(gameObject);
            Debug.Log("boom");
        }
    }
}
