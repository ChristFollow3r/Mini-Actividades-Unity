using UnityEngine;

public class printingVector : MonoBehaviour
{
    public Vector3 toBePrintedVector = new Vector3(0, 0, 0);
    void Start()
    {
        Debug.Log(toBePrintedVector);
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
