using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject enemy;
    public GameObject lastEnemy;
    
	// Use this for initialization
	void Start () {
        lastEnemy = Instantiate(enemy);
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
        Destroy(lastEnemy);
        lastEnemy = Instantiate(enemy);
        Debug.Log("Enemy removed");
    }
}
