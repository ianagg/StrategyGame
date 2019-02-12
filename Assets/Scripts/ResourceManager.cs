using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {

    public Text moneytext;
    public Text ideatext;


    private int money;
    private int idea;


	// Use this for initialization
	void Start () {
        money = 110;
        idea = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddMoney(int add) {
        this.money += add;
        moneytext.text = money.ToString();
        
    }

    public void AddIdea(int add)
    {
        this.idea += add;
    }

    public int GetMoney()
    {
        return this.money;
    }

    public int GetIdea()
    {
        return this.idea;
    }


    public void SubMoney(int add)
    {
        this.money -= add;
        moneytext.text = money.ToString();

    }

    public void SubIdea(int add)
    {
        this.idea -= add;
    }


}


