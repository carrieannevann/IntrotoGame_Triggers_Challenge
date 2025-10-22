using UnityEngine;

public class TriggerSetActive : MonoBehaviour
{
    [Header("Target Animation")]
    public Animator targetAnimator;     // Drag the animated cube's Animator here
    public string triggerName = "Play"; // The name of the animation trigger

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetAnimator.SetTrigger(triggerName);
        }
    }
}
