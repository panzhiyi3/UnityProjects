using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform shooterTrans;
    public GameObject bullet;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randPos = shooterTrans.position;
            randPos.y = Random.Range(-1.5f, 1.5f);
            Instantiate(bullet, randPos, bullet.transform.rotation);
        }
	}
}
