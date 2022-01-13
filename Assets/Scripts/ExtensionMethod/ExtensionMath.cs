using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMath
{

    public static float Min(this float f, float compareWith)
    {
        return f < compareWith ? f : compareWith;
    }
    public static float Sign(this float f)
    {
        return Mathf.Sign(f);
    }
    public static float Abs(this float f)
    {
        return Mathf.Abs(f);
    }

    public static float Sqrt(this float f)
    {
        return Mathf.Sqrt(f);
    }
    public static float PowSigned(this float f, float p)
    {
        return Mathf.Pow(f.Abs(), p) * f.Sign();
    }

    

    public static float Clamp(this float f, float min, float max)
    {
        return Mathf.Clamp(f, min, max);
    }
    public static int Clamp(this int f, int min, int max)
    {
        return Mathf.Clamp(f, min, max);
    }
    public static float ClampMin(this float f, float min)
    {
        return f > min ? f : min;
    }
    public static float ClampAbsMin(this float f, float min)
    {
        float fas = Mathf.Abs(f);
        float fsi = Mathf.Sign(f);
        fas = fas < min ? min : fas;
        return fas * fsi;
    }
    public static float ClampMax(this float f, float max)
    {
        return f < max ? f : max;
    }
    public static float ClampAbsMax(this float f, float max)
    {
        return f.Abs() < max.Abs() ? f : max.Abs() * f.Sign();
    }
    public static int ClampMax(this int i, int max)
    {
        return i < max ? i : max;
    }
    public static int ClampMin(this int i, int Min)
    {
        return i > Min ? i : Min;
    }

    


    public static Vector2 Map(this int f, int inputStart, int inputEnd, Vector2 outputStart, Vector2 outputEnd, bool clamp = true)
    {
        float f1 = f;
        if (clamp) f1 = f.Clamp(inputStart, inputEnd);
        return (f1 - inputStart) / (inputEnd - inputStart) * (outputEnd - outputStart) + outputStart;
    }
    public static float Map(this float f, float inputStart, float inputEnd, float outputStart, float outputEnd, bool clamp = true)
    {
        float f1 = f;
        if (clamp) f1 = f.Clamp(inputStart, inputEnd);
        return (f1 - inputStart) / (inputEnd - inputStart) * (outputEnd - outputStart) + outputStart;
    }
    public static Vector2 Map(this float f, float inputStart, float inputEnd, Vector2 outputStart, Vector2 outputEnd, bool clamp = true)
    {
        float f1 = f;
        if (clamp) f1 = f.Clamp(inputStart, inputEnd);
        return (f1 - inputStart) / (inputEnd - inputStart) * (outputEnd - outputStart) + outputStart;
    }
}
