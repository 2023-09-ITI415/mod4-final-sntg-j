using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HouseOnHill : MonoBehaviour
{
    public LogicScript Logic;
    public GameObject CompletedObjectiveText;
    string winText;
    private void Start()
    {
        CompletedObjectiveText.SetActive(false);
        string winText = CompletedObjectiveText.GetComponent<TextMeshProUGUI>().text.ToString();
    }
    void OnTriggerEnter(Collider collision)
    {
        bool check = Logic.CheckCompletion();
        Debug.Log(check.ToString());
        if (check && collision.gameObject.tag == "Player")
        {
            CompletedObjectiveText.SetActive(true);
        }
    }
}
