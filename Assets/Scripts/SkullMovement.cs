using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] public bool canMove = false;
    [SerializeField] private float _speed = 4f;

    private void Update()
    {
        float singleStep = _speed * Time.deltaTime;
        var targetDirection = _transform.position - new Vector3(-0.8f, -1.25f - 0.8f);

        if (canMove)
            gameObject.transform.position = Vector3.MoveTowards(transform.position, targetDirection, singleStep);

        transform.LookAt(targetDirection);
    }
}
