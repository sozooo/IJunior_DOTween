using DG.Tweening;
using UnityEngine;

public class CapsuleScaler : ObjectTween
{
    [SerializeField] private Vector3 _endValue;

    private void Start()
    {
        transform.DOScale(_endValue, Duration).SetLoops(Repeats, LoopMode);
    }
}
