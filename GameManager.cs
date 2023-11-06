using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public GameObject enemytwoPrefab;
  void Start()
    {
        InvokeRepeating("CreateEnemyTwo", 2.0f, 4.0f); //time period
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemyTwo()
    {
        //y axis is what lowers it 
        Instantiate(enemytwoPrefab, new Vector3(Random.Range(5, 7), 1, 0), Quaternion.identity);
    }

}
