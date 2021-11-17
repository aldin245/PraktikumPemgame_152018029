using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFunction : MonoBehaviour
{
    [SerializeField] MenuButtonController MenuButtonController;
    // Start is called before the first frame update
    void PlaySound(AudioClip WhichSound)
    {
        MenuButtonController.audioSource.PlayOneShot(WhichSound);
    }
}
