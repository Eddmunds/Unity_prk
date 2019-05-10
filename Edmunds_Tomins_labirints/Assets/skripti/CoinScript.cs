using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {
    public Text text;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(90 * Time.deltaTime, 0, 0); 
    }

    private void OnTriggerEnter(Collider other) //tikai piejams tad, ja collider ir set to trigger
    {
        if (other.tag == "Player")
        {
            CounterSkript.instance.currentAmount += 1;
            text.text = CounterSkript.instance.currentAmount.ToString();
            Debug.Log(CounterSkript.instance.currentAmount);
            Destroy(gameObject);
        }
    }

}