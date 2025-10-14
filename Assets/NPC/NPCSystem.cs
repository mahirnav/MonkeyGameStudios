using UnityEngine;

public class NPCSystem : MonoBehaviour
{
    bool playerDetection = false;

    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.E))
        {
            print("Dialogue Started");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBody"))
        {
            playerDetection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerBody"))
        {
            playerDetection = false;
        }
    }
}