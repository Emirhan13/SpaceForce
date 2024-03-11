using UnityEngine;

public class BulletControl : MonoBehaviour
{
    #region [SerializeField] Veriables 
    [SerializeField] float V_BulletSpeed;
    [SerializeField] float V_BulletDamage;
    #endregion
    #region [Private] Veriables
    private Rigidbody V_BulletRb;
    #endregion

    #region Unity Funcs
    private void Start()
    {
        V_BulletRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        F_BulletSpeedControl();
    }
    #endregion



    #region Bullet Control Funcs
    private void F_BulletSpeedControl()
    {
        V_BulletRb.velocity = new Vector3(V_BulletRb.velocity.x, V_BulletRb.velocity.y, V_BulletSpeed);
    }
    #endregion




    #region Triggers Funcs
    private void OnTriggerEnter(Collider other)
    {
       
        Iinteractionable interaction = other.GetComponent<Iinteractionable>();
        if(interaction != null)
        {
            interaction.Interaction(V_BulletDamage);
            Destroy(gameObject);
           
        }
       
      
    }


    #endregion
}
