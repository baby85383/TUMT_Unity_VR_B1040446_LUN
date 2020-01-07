using UnityEngine;
using UnityEngine.UI;

public class Knight : MonoBehaviour
{
    public static bool knight1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "刀")
        {
            Destroy(gameObject);
            knight1 = true;
        }
    }
}
