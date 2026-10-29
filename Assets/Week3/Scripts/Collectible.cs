using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int points = 1;
    [SerializeField] private float turnSpeed = 90f;

    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void Update()
    {
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddScore(points);
            Destroy(gameObject);
        }
    }
}