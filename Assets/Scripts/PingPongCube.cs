using UnityEngine;

public class PingPongCube : MonoBehaviour
{

    public float speed = 2.0f;
    public float distance = 10f;
    private float startPoint;
    void Start()
    {
        startPoint = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(startPoint +x, transform.position.y,transform.position.y);
    }
}
