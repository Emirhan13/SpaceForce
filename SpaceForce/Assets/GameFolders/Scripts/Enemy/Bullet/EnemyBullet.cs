using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    #region [Public] Varibles
    #endregion
    #region [SerializeField] Variables
    [SerializeField] float V_BulletSpeed;
    [SerializeField] float V_BulletDamage;
    #endregion
    #region [Private]
    private Rigidbody V_BulletRb;
    #endregion
    void Start()
    {
        V_BulletRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        F_BulletPowerControl();
    }

    #region Bullet power funcs
    private void F_BulletPowerControl()
    {
        V_BulletRb.velocity = new Vector3(V_BulletRb.velocity.x, V_BulletRb.velocity.y, -V_BulletSpeed);
    }
    #endregion
    #region Trigger Funcs
    private void OnTriggerEnter(Collider other)
    {
        Iinteractionable interactionable = other.GetComponent<Iinteractionable>();
        if (interactionable != null)
        {
            interactionable.Interaction(V_BulletDamage);
            Destroy(gameObject);
        }
    }
    #endregion
}
