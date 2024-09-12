using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Transform Target;
    private float speed = 5f;

   
    private void Update()
    {
        if (Target != null)
        {
            Vector3 direction = (Target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
