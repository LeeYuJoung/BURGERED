using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 moveDirection;
    private Rigidbody rb;

    public float moveSpeed = 10f;
    public float currentTime = 0.0f;

    public bool isPick;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PlayerMove();
    }

    //플레이어 이동
    public void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        moveDirection.Set(h, 0f, v);
        moveDirection = moveDirection.normalized * moveSpeed * Time.deltaTime;

        if (!(h == 0 && v == 0))
        {
            transform.position += moveDirection;
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }
    }
}
