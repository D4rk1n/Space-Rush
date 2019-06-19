using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    public float Speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = Speed * HThrow * Time.deltaTime ;
        float dX = transform.localPosition.x + xOffset;
        dX = Mathf.Clamp(dX, -6, 6);
        transform.localPosition = new Vector3(dX, transform.localPosition.y, transform.localPosition.z);

        float VThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = Speed * VThrow * Time.deltaTime;
        float dY = transform.localPosition.y + yOffset;
        dY = Mathf.Clamp(dY, -3, 3);
        transform.localPosition = new Vector3(transform.localPosition.x, dY, transform.localPosition.z);

    }
}
