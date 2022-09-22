using UnityEngine;

public class AutomaticBridgeController : MonoBehaviour
{
    public Transform BridgeGate;

    public Vector3 openedPosition;
    public Vector3 closedPosition;

    public float openSpeed;
    private bool isOpened;
    public bool requirementMet;

    private void Start()
    {
        isOpened = false;
        requirementMet=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(requirementMet)
        {
            if (isOpened)
            {
                BridgeGate.position = Vector3.Lerp(BridgeGate.position, openedPosition, Time.deltaTime * openSpeed);
                GameObject.Find("Main Camera").GetComponent<CameraFollow>().offSet = new Vector3(0,0.6f,-1);
            }

            else
            {
                BridgeGate.position = Vector3.Lerp(BridgeGate.position, closedPosition, Time.deltaTime * openSpeed);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            this.isOpened = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            this.isOpened = false;
    }
}

