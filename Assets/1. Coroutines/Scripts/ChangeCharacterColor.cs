using UnityEngine;
using System.Collections;

public class ChangeCharacterColor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color targetColor = Color.red;
    public float colorDuration = 2f;

    public IEnumerator ChangeColor()
    {
        Color startColor = spriteRenderer.color;
        float timer = 0f;

        while (timer < colorDuration)
        {
            timer += Time.deltaTime;

            float t = timer / colorDuration;

            spriteRenderer.color = Color.Lerp(
                startColor,
                targetColor,
                t
            );

            yield return null;
        }

        spriteRenderer.color = targetColor;
    }
}
