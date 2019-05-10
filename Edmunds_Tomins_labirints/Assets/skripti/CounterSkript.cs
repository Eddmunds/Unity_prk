using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //izmanto lai piekļūtu UI funkcionalitātei un datu tipiem

public class CounterSkript : MonoBehaviour {
    public int currentAmount = 0;
    public GameObject endScreen;
    public Text text;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController Player; //targeto fps controller
   
    [SerializeField] //ļauj iekš editor redzēt un piekļūt private mainīgajam
    private int maxAmount = 4;
    public static CounterSkript instance; //izveido skripta instanci(tikai tad ja viens tāds skripts)
    

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        text.text = maxAmount.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (currentAmount >= maxAmount)
        {
            endScreen.SetActive(true);
            Player.enabled = false;
            Cursor.lockState = CursorLockMode.None;
           Cursor.visible = true;
            currentAmount = 0;
        }
      
	}
}