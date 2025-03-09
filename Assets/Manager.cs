using UnityEngine;

public delegate void OnTest();
public class Manager : MonoBehaviour
{
    public static OnTest onTest_del;
    public GameObject obj;
    public int count;

    void Start(){
        for (int c = 0; c < count; c++)
        {
            Instantiate(obj).name += " "+c.ToString();
        }
    }
    private void Update() {
        if(onTest_del != null){
            onTest_del.Invoke();

            Destroy(gameObject);
        }
    }

    void Event()
    {
        print("GameObject Name: " + gameObject.name);
    }
}
