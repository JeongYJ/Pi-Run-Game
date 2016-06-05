using UnityEngine;
using System.Collections;

public class MapMove : MonoBehaviour
{

    float Speed;
    float RealSpeed;
    

    // Use this for initialization
    void Start()
    {

        Speed = 10f;
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
            RealSpeed = Speed * (float)1.5;
        else
            RealSpeed = Speed;

        //transform.Translate(new Vector3(0.0f, 0.0f, -RealSpeed) * Time.deltaTime);

        float posZ = Mathf.Lerp(transform.position.z, transform.position.z - RealSpeed, 1 * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, transform.position.y, posZ);

        if (posZ <= -110)
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 200);
            
        }
}
