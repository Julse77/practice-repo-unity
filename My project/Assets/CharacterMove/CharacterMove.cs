using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 10f;       // 이동속도
    private Rigidbody characterRigidbody;

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();        
    }

    void Update()
    {
        // -1 ~ 1 입력
        float horizontalInput = Input.GetAxis("Horizontal");    // 좌우
        float verticalInput = Input.GetAxis("Vertical");        // 상하

        float fallSpeed = characterRigidbody.velocity.y;        // 떨어지는 속도

        Vector3 velocity = new Vector3(horizontalInput, 0, verticalInput);
        velocity *= moveSpeed;
        velocity.y = fallSpeed;     // 떨어지는 속도 초기화
        characterRigidbody.velocity = velocity;
    }
}
