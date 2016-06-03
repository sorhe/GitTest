using UnityEngine;
using System.Collections;

public class BranchTest1 : MonoBehaviour {
    public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(transform.forward, Space.World);
        }
    }
}
