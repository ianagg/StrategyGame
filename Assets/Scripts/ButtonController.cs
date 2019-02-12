using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    public GameObject[] strucs;
    public List<string> names;
    public List<int> sums;
    public ResourceManager man;


    public void OnClick(Button button)
    {
        int ind = names.IndexOf(button.name);

        if (man.GetMoney() > (sums[ind] - 1))
        {
            man.SubMoney(sums[ind]);
            strucs[ind].SetActive(true);
            button.interactable = false;
        }
    }
}
