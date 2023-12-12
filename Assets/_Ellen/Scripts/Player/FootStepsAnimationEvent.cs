using UnityEngine;

public class FootStepsAnimationEvent : MonoBehaviour
{
    [SerializeField]
    private PlayerSoundController soundController;

    public void PlayFootStepSound()
    {
        soundController.Play(soundController.FootStepsFX);
    }
}
