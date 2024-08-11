using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    public int damageRate;
    Rigidbody shell;
    public Transform clip;
    private GameObject target;
    private GameObject currentShell;
    public float frequency;
    public float shootForce;
    private float time;
    public string shellName = "bullet";
    Vector3 aimingOffset;
    // Start is called before the first frame update
    void Start()
    {
        aimingOffset = new Vector3(0, 0.1f, 0);
        time = frequency;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetTarget();
        if (target != null)
        {
            time += Time.deltaTime;
            if (time > frequency)
            {
                AttackTarget();
                time = 0;
            }
        }
    }
    void AttackTarget()
    {
        Vector3 direction = ((target.transform.position + aimingOffset) - clip.transform.position).normalized;
        float angle = Vector3.Angle(clip.forward, direction);

        if (angle < 5.0f)
        {
            currentShell = ShellPool.Instance.GetBullet(shellName, damageRate);
            currentShell.transform.position = clip.transform.position;
            shell = currentShell.GetComponent<Rigidbody>();
            shell.AddForce(direction * shootForce, ForceMode.Impulse);
        }
    }

    void SetTarget()
    {
        TankTowerControll targetSearch = GetComponent<TankTowerControll>();
        target = targetSearch.GetTarget();
    }
}
