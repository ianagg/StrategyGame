using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehavior : MonoBehaviour {

   
    public Transform res;
    public Transform home;
    public float speed;

    private Transform target;
    private int current;
    private ResourceManager man;

    // Use this for initialization
    void Start () {

        target = res;
        man = GameObject.FindGameObjectWithTag("Tagged").GetComponent<ResourceManager>();

	}


    Vector2 pos;
    bool toggle = false;
    // Update is called once per fame
    void FixedUpdate () {

      
        if (transform.position != target.position)
        {
            toggle = false;
            pos = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);

        }
        else
        {
            if (toggle)
            {
                if (target.position == res.position)
                    target = home;
                else
                {
                    target = res;
                    man.AddMoney(10);
                }
            }
            StartCoroutine(Wait());
        }

    }

    IEnumerator Wait()
    {
       // print(Time.time);
        yield return new WaitForSeconds(2);
        toggle = true;
        //print(Time.time);
    }


    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //    Debug.Log("hit");
    //  pos = Vector2.MoveTowards(transform.position, Mathf.Sin(angtarget[current].position), speed * Time.deltaTime);
    //}

}
