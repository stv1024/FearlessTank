using UnityEngine;

/// <summary>
/// 子弹
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// 撞击后的特效
    /// </summary>
    public GameObject EffectTemplate;
    /// <summary>
    /// 撞击后的音效
    /// </summary>
    public AudioClip SoundEffect;
    /// <summary>
    /// 撞击发生
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        print("Hit!");

        GameObject go = Instantiate(EffectTemplate);//创建特效实例
        go.transform.position = transform.position;//改变特效位置为撞击时子弹的位置
        Destroy(go, 5);//5秒后销毁特效
        AudioSource.PlayClipAtPoint(SoundEffect, transform.position);//在子弹位置播放音效，3D音效需要指定位置
        Destroy(gameObject);//销毁子弹
    }
}