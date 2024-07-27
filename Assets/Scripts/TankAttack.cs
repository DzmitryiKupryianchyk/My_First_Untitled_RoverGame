using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
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
        aimingOffset = new Vector3(0, 0.15f, 0);
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
        //if (target != null )
        //{
        //    Debug.Log("Pew");
        //    currentShell = ShellPool.Instance.GetBullet(shellName);
        //    currentShell.transform.position = clip.transform.position;
        //    shell = currentShell.GetComponent<Rigidbody>();
        //    Vector3 direction = ((target.transform.position + aimingOffset) - clip.transform.position).normalized;
        //    shell.AddForce(direction * shootForce, ForceMode.Impulse);
        //}
        //if (target != null)
        //{
        //    Vector3 direction = ((target.transform.position + aimingOffset) - clip.transform.position).normalized;
        //    float angle = Vector3.Angle(clip.forward, direction);

        //    if (angle < 5.0f)
        //    {
        //        Debug.Log("Pew");
        //        currentShell = ShellPool.Instance.GetBullet(shellName);
        //        currentShell.transform.position = clip.transform.position;
        //        shell = currentShell.GetComponent<Rigidbody>();
        //        shell.AddForce(direction * shootForce, ForceMode.Impulse);
        //    }
        //    else
        //    {
        //        Debug.Log("Turret is not in position");
        //    }
        //}
        Vector3 direction = ((target.transform.position + aimingOffset) - clip.transform.position).normalized;
        float angle = Vector3.Angle(clip.forward, direction);

        if (angle < 5.0f)
        {
            Debug.Log("Pew");
            currentShell = ShellPool.Instance.GetBullet(shellName);
            currentShell.transform.position = clip.transform.position;
            shell = currentShell.GetComponent<Rigidbody>();
            shell.AddForce(direction * shootForce, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("Turret is not in position");
        }
    }

    void SetTarget()
    {
        TankTowerControll targetSearch = GetComponent<TankTowerControll>();
        target = targetSearch.GetTarget();
    }
}
