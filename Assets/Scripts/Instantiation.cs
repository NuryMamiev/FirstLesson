using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject[] prefab;
    private GameObject instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (prefab == null)
            {
                Debug.LogError("Prefab is Null");
                return;
            }

            if (instance != null)
            {
                Destroy(instance);
            }

            var randomNum = Random.Range(0, prefab.Length);
            var rotation = Quaternion.identity;
            var position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            instance = Instantiate(prefab[randomNum], position, rotation);
            
            
        }

    }
}
