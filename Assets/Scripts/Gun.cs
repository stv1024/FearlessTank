using UnityEngine;

/// <summary>
/// 枪
/// </summary>
public class Gun : MonoBehaviour
{
    /// <summary>
    /// 子弹模板
    /// </summary>
    public GameObject BulletTemplate;
    /// <summary>
    /// 创建子弹的位置
    /// </summary>
    public GameObject LaunchPoint;
    /// <summary>
    /// 子弹速度
    /// </summary>
    public float BulletSpeed;
    /// <summary>
    /// 开火
    /// </summary>
    public void Fire()
    {
        GameObject go = Instantiate(BulletTemplate);//创建子弹实例
        go.transform.position = LaunchPoint.transform.position;//子弹位置改为发射点位置
        go.GetComponent<Rigidbody>().velocity = LaunchPoint.transform.forward*BulletSpeed;//子弹的速度是发射方向×速度值
        go.transform.up = LaunchPoint.transform.forward;//子弹的朝向是发射方向

        GetComponent<AudioSource>().Play();//播放枪自带的开火音效
    }
}
