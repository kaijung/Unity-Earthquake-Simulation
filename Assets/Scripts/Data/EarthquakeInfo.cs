using UnityEngine;

[System.Serializable]
public class EarthquakeInfo
{
    public EarthquakeAxis XAxis;
    public EarthquakeAxis YAxis;
    public EarthquakeAxis ZAxis;
    public float MaxSeconds;
    public Vector3 AverageAcceleration;

    public EarthquakeInfo(EarthquakeAxis x , EarthquakeAxis y, EarthquakeAxis z)
    {
        XAxis = x;
        YAxis = y;
        ZAxis = z;
    }

}
