using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] Animator V_Animator;
    [SerializeField] AudioSource V_Source;
  
    private void F_AnimatorControl(string AniName, bool Index)
    {
        V_Animator.SetBool(AniName, Index);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            F_AnimatorControl("Door",true);
            V_Source.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            F_AnimatorControl("Door", false);
            V_Source.Stop();
        }
    }
}
