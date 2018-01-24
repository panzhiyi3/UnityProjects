using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public float explosionForce;
    public float explosionRadius;
    public Vector3 forcePos;
    public float lifeTime;

    private Rigidbody rb;
	void Start ()
    {
		rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(explosionForce, gameObject.transform.position + forcePos, explosionRadius);
        Destroy(gameObject, lifeTime);
    }
}
