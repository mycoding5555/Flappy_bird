using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] private float _speedPipe = 0.7f;
   


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speedPipe * Time.deltaTime;
    }
}
