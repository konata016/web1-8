using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

    public Text life;
    int LifeCount = 3;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //ライフ制御
        life.text = "Life:" + LifeCount.ToString();

        if (LifeCount == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "igaguri")
        {
            LifeCount -= 1;
        }
    }
}
