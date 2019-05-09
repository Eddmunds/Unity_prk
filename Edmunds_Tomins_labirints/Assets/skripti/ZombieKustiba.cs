using System.Collections;
using UnityEngine;

public class ZombieKustiba : MonoBehaviour {
	public Transform target;
	public Transform myTransform;
    // Update is called once per frame
    void Update()
    {

    	transform.LookAt(target);
    	transform.Translate(Vector3.forward*1*Time.deltaTime);
        
    }
}
