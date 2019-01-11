using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        Instantiate(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EnemyRespawn();
            }
        }
	
    void EnemyRespawn()
    {
        Destroy(gameObject);
        Instantiate(gameObject);
        Debug.Log("Enemy removed");
    }
}
