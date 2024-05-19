using DG.Tweening;
using UnityEngine;

public class ObjectTween : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopMode;

    protected float Duration => _duration;
    protected int Repeats => _repeats;
    protected LoopType LoopMode => _loopMode;
}