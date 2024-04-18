using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemyOne;
    public GameObject coin;

    private Vector3 spawn = new Vector3(18, -3, -0);
    
    void Start()
    {
        InvokeRepeating(nameof(spawnCoins), 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemies()
    {
        Instantiate(enemyOne, spawn, enemyOne.transform.rotation);
    }
    void spawnCoins()
    {
        Instantiate(coin, spawn, coin.transform.rotation);
    }
}
