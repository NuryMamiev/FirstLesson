using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float growthTime = 1.0f;
    public float maxSize = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.localScale.x < maxSize) 
        {
            Vector3 growth = Vector3.one * growthTime* Time.deltaTime;
            transform.localScale += growth;
        }
        if( transform.localScale.x >= maxSize)
        {
            transform.localScale = new Vector3(maxSize, maxSize,maxSize);
        }
    }
}
