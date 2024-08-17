using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : ShellSingleton<SoundManager>
{
    public AudioClip shootSound;
    public AudioClip hitSound;
    public AudioClip bounceSound;
    public AudioClip explosionSound;

    public AudioSource audioSource;

    public void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
        audioSource.volume = 0.8f;
    }

    public void PlayHitSound()
    {
        audioSource.volume = 0.4f;
        audioSource.PlayOneShot(hitSound);
    }

    public void PlayBounceSound()
    {
        audioSource.PlayOneShot(bounceSound);
    }

    public void PlayExplosionSound()
    {
        audioSource.PlayOneShot(explosionSound);
        audioSource.volume = 1.2f;
    }
}
