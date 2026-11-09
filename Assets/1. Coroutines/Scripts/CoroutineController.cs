using UnityEngine;
using System.Collections;

public class CoroutineController : MonoBehaviour
{
    [SerializeField] MoveCharacter moveScript;
    [SerializeField] ChangeCharacterColor colorScript;
    [SerializeField] RotateCharacter rotateScript;

    void Start()
    {
        // Start the main coroutine here
    }

    IEnumerator PlaySequence()
    {
        // 1. Move the character
        
        // 2. Change the character's color

        // 3. Rotate the character

        // All effects completed!
    }
}
