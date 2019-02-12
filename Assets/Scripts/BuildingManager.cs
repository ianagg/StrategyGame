using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {


    public int health;
    public GameObject unit;
    public Transform pos;
    private ResourceManager man;


    // Use this for initialization
    void Start()
    {

        man = GameObject.FindGameObjectWithTag("Tagged").GetComponent<ResourceManager>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnMouseDown()
    {
        if (man.GetMoney() > 9)
        {

            man.SubMoney(10);
            GameObject unitSp = Instantiate(unit, pos.position, pos.rotation);
            unitSp.GetComponent<UnitBehavior>().home = GetComponentInChildren<Transform>().GetChild(0).transform;


        }
    }
}
