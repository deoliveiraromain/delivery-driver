using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	// Start is called before the first frame update

	[SerializeField]
	private GameObject gameObjectToFollow;
    private Vector3 belowAmount = new Vector3(0,0,-10);

	void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
		transform.position = gameObjectToFollow.transform.position + belowAmount;
	}
}
