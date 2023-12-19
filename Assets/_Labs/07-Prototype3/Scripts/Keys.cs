using UnityEngine;

public class Keys : MonoBehaviour
{
    public LogicScript Logic; 
    Vector3 spin = new Vector3(15, 30, 45);
    private void Start()
    {
//        Logic = GetComponent<LogicScript>();
    }
    // Update is called once per frame
    void Update()
    {
        // Rotates the game object that this script is attached to by 15 in the X axis,
        // 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
        // rather than per frame
        transform.Rotate(spin * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            Logic.SetObjectiveText();
        }
    }


}
