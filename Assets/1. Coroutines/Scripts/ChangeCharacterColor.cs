using UnityEngine;
using System.Collections;

public class ChangeCharacterColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color startColor;  

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startColor = spriteRenderer.color;
    }

    public IEnumerator ChangeColor(Color targetColor, float changeDuration)
    {
        float timer = 0f;

        // Change the color over time
        while (timer < changeDuration)
        {
            timer += Time.deltaTime;
            float t = timer / changeDuration;
            spriteRenderer.color = Color.Lerp(startColor, targetColor, t); // Interpolate between the start and target colors
            yield return null;
        }
    }
}
