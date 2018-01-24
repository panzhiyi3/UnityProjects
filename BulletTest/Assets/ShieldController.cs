using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public float rotateSpeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Input.GetMouseButton(0))
        {
            Vector3 aimPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0 /*Camera.main.transform.position.y*/));
            Vector3 dir = (aimPos - transform.position);
            dir.z = 0;
            dir = dir.normalized;

            Quaternion targetRotation = Quaternion.LookRotation(dir, Vector3.up);
            Quaternion newRotation = Quaternion.Lerp(rb.rotation, targetRotation, rotateSpeed * Time.deltaTime);
            rb.MoveRotation(newRotation);

            //if (Vector3.Distance(aimPos, transform.position) > 0.1f)
            //{
            //    rb.MovePosition(dir * Time.fixedDeltaTime * moveSpeed + transform.position);
            //}
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.collider.CompareTag("Bullet"))
        //{
        //    ContactPoint contactPoint = collision.contacts[0];
        //    Vector3 newDir = Vector3.zero;
        //    Vector3 curDir = transform.TransformDirection(Vector3.forward);
        //    newDir = Vector3.Reflect(curDir, contactPoint.normal);
        //    Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, newDir);
        //    transform.rotation = rotation;

        //    Rigidbody rbCollider = collision.collider.GetComponent<Rigidbody>();
        //    rbCollider.velocity = newDir.normalized * rbCollider.velocity.x / rbCollider.velocity.normalized.x;
        //    Debug.Log(rbCollider.velocity);
        //}

        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    //contact.normal;
        //}
    }
}
