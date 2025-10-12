using StarterAssets;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public ThirdPersonController tpc;
    public float speedTime = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (tpc.speedMult >= 2)
        {
            speedTime -= Time.deltaTime;

            if (speedTime <= 0)
            {
                tpc.speedMult = 1;
                speedTime = 15f;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && Input.GetMouseButton(0))
        {
            Destroy(collision.gameObject);
            tpc.speedMult++;
            Debug.Log("ping!");
        }
    }
}
