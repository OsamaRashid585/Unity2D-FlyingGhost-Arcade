using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    public float _moveSpeed;
    private Vector3 _startPos;
    public float _offSetPos;
    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
        if(transform.position.x <= _offSetPos)
        {
            transform.position = _startPos;
        }
    }
}
