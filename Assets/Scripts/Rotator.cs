using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rotationAngle = new Vector3(0,90,0);
        transform.Rotate(rotationAngle * rotationSpeed* Time.deltaTime);
    }
}
