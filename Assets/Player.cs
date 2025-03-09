using UnityEngine;


public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Manager.onTest_del += Event;
    }

    // Update is called once per frame
    void Event()
    {
        print("GameObject Name: " + gameObject.name);
    }
}
