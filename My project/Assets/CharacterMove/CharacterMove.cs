using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 10f;       // 이동속도
    public float jumpForce = 5f;        // 점프힘
    private bool isJumping;
    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();        // Player에서 rigidbody 가져옴
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        // -1 ~ 1 입력
        float horizontalInput = Input.GetAxis("Horizontal");    // 좌우
        float verticalInput = Input.GetAxis("Vertical");        // 상하

        float fallSpeed = playerRigidbody.velocity.y;        // 떨어지는 속도

        Vector3 velocity = new Vector3(horizontalInput, 0, verticalInput);
        velocity *= moveSpeed;
        velocity.y = fallSpeed;     // 떨어지는 속도 초기화
        playerRigidbody.velocity = velocity;
    }

    void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("점프");
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
    }


}
