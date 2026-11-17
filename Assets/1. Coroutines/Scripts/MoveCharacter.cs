using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{
    public IEnumerator Move(Vector3 targetPosition, float moveDuration)
    {
        Vector3 startPosition = transform.position;
        float timer = 0f;

        while (timer < moveDuration)
        {
            timer += Time.deltaTime;
            float t = timer / moveDuration;
            transform.position = Vector3.Lerp(startPosition, targetPosition, t); // Interpolate between the start and target positions
            yield return null;
        }
    }
}
