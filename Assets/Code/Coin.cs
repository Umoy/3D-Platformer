using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject coinObj = null;
    public Vector3 coinObjRot = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {
        if (coinObj == null)
            coinObj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        coinObj.transform.eulerAngles = coinObjRot;
        coinObjRot.x += 1.5f;
        if (coinObjRot.x >= 360)
        {
            coinObjRot.x = 0;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            //The number of coins is updated
            player.CollectCoins();

            //The coin that was collected is destroyed
            Destroy(gameObject);
        }
    }
    
}
