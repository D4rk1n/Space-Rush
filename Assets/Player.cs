using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    public float Speed = 20;
    public float pitchFactor = -5;
    public float yawFactor = 5;
    public float rollFactor = 5;
    // Start is called before the first frame update

    bool Alive;
    void Start()
    {
        Alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Alive)
        {
            MovementComponent();
        }
    }



    private void Death()
    {
        Alive = false;
    }

    private void MovementComponent()
    {
        float HThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float VThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = Speed * VThrow * Time.deltaTime;

        float dX, dY;
        Translate(HThrow, yOffset, out dX, out dY);
        Rotate(HThrow, VThrow, dX, dY);
    }

    private void Rotate(float HThrow, float VThrow, float dX, float dY)
    {
        float pitch = dY * pitchFactor - Mathf.Abs(dY) * 2 * VThrow;
        float yaw = dX * yawFactor + Mathf.Abs(dX) * 2 * HThrow;
        float roll = HThrow * rollFactor;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    private void Translate(float HThrow, float yOffset, out float dX, out float dY)
    {
        float xOffset = Speed * HThrow * Time.deltaTime;
        dX = transform.localPosition.x + xOffset;
        dX = Mathf.Clamp(dX, -7, 7);
        transform.localPosition = new Vector3(dX, transform.localPosition.y, transform.localPosition.z);

        dY = transform.localPosition.y + yOffset;
        dY = Mathf.Clamp(dY, -5, 5);
        transform.localPosition = new Vector3(transform.localPosition.x, dY, transform.localPosition.z);
    }
}
