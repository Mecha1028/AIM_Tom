using UnityEngine;

public class PulseHighlight : MonoBehaviour
{
    [SerializeField] private Color highlightColour = Color.cyan;
    [SerializeField] private float speed = 2f;

    private Material coinMaterial;
    private Color originalColour;

    private void Start()
    {
        coinMaterial = GetComponentInChildren<Renderer>().material;
        originalColour = coinMaterial.color;
    }

    private void Update()
    {
        float pulse = Mathf.PingPong(Time.time * speed, 1f);
        coinMaterial.color = Color.Lerp(originalColour, highlightColour, pulse);
    }
}