using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{
    public Vector3 targetPosition;
    public float moveDuration = 2f;

    public IEnumerator Move()
    {
        Debug.Log("Move started");
        Vector3 startPosition = transform.position;
        float timer = 0f;

        while (timer < moveDuration)
        {
            timer += Time.deltaTime;

            float t = timer / moveDuration;

            transform.position = Vector3.Lerp(
                startPosition,
                targetPosition,
                t
            );

            yield return null;
        }

        transform.position = targetPosition;
    }
}
