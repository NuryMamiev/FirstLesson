using UnityEngine;

public class Teleportator : MonoBehaviour
{
    public float interval = 2f;
    public float lastTeleport = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTeleport >= interval)
        {
            Teleport();
            lastTeleport = Time.time;
        }

        void Teleport()
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);

            transform.position = new Vector3(x, y, z);
        }
        
    }
}
