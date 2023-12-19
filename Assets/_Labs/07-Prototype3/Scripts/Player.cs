using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript Logic;
    private void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject collidedWith = other.gameObject;
        if (collidedWith.tag == "PickUp")
        {
            // Destroys the gameObject to quicken the runspeed of the game
            collidedWith.SetActive(false);
            Logic.SetObjectiveText();
        }
    }
}
