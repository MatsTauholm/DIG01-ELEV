using UnityEngine;
using System.Collections;

public class RotateCharacter : MonoBehaviour
{
    public float rotationDuration = 2f;

    public IEnumerator Rotate()
    {
        float timer = 0f;

        while (timer < rotationDuration)
        {
            timer += Time.deltaTime;

            float angle = 360f * (timer / rotationDuration);

            transform.rotation = Quaternion.Euler(0, 0, angle);

            yield return null;
        }

        transform.rotation = Quaternion.identity;
    }
}

