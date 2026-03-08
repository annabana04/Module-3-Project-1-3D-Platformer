using UnityEngine;

public class CollectGems : MonoBehaviour
{

    int value = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(value);
            Destroy(gameObject);
        }
    }
}
