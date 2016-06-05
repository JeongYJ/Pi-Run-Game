using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{

    Rigidbody rigidbody;
    float jumpPower = 10f;

    bool isJump = false;
    // Use this for initialization
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) )
            isJump = true;

        if (isJump)
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

        isJump = false;

    }
}
