using UnityEngine;

public class PlatformsMovement : MonoBehaviour
{
    public Transform[] platforms;
    
    private bool[] movements=new  bool[2];
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (platforms[0].position.x <= 87.32468)
            movements[0] = true;
        else if (platforms[0].position.x >= 88.15)
            movements[0] = false;

        if (platforms[1].position.z <= 18)
            movements[1] = true;
        else if (platforms[1].position.z >= 19.5)
            movements[1] = false;

        if (movements[0]==true)
            platforms[0].position = new Vector3(platforms[0].position.x + 0.01f, platforms[0].position.y, platforms[0].position.z);
        else
            platforms[0].position = new Vector3(platforms[0].position.x - 0.01f, platforms[0].position.y, platforms[0].position.z);

        if (movements[1] == true)
            platforms[1].position = new Vector3(platforms[1].position.x,platforms[1].position.y, platforms[1].position.z + 0.015f);
        else
            platforms[1].position= new Vector3(platforms[1].position.x,platforms[1].position.y, platforms[1].position.z - 0.015f);
    }
}
