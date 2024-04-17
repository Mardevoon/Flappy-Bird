using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Piper : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
