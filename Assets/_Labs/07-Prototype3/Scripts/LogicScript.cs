using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI ObjectiveText;
    GameObject[] Objectives;
    private bool ObjCompleted = false;
    private int count;

    void Start()
    {
        count = 0;
        Objectives = GameObject.FindGameObjectsWithTag("Pickup");
    }

    public void SetObjectiveText()
    {
        count++;
        ObjectiveText.text = "Keys Found: " + count.ToString() + "/2";
        if(count >= Objectives.Length)
        {
            ObjCompleted = true;
        }
    }
    public int getObjectiveCount() { return count; }
    public bool CheckCompletion() { return ObjCompleted; }
}
