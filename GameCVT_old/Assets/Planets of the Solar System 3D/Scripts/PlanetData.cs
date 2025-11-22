
using Newtonsoft.Json;
using UnityEngine;

[System.Serializable]
public class PlanetData
{
    
    public double albedo;
    public double altitude;

    [JsonProperty(PropertyName = "altitude-geometric")]
    public double altitude_geometric;

    public double ambientInt;
    public double ambientLum;
    public string appSidTm;
    public double azimuth;

    [JsonProperty(PropertyName = "azimuth-geometric")]
    public double azimuth_geometric;

    public double? central_b;
    public double? central_l;
    public double dec;
    public double decJ2000;
    public string distance;

    [JsonProperty(PropertyName = "distance-km")]
    public double distance_km;
    [JsonProperty(PropertyName = "ecl-elongation")]
    public double ecl_elongation;
    [JsonProperty(PropertyName = "ecl-elongation-deg")]
    public string ecl_elongation_deg;
    [JsonProperty(PropertyName = "ecl-elongation-dms")]
    public string ecl_elongation_dms;
    [JsonProperty(PropertyName = "ecliptic-obliquity")]
    public double ecliptic_obliquity;

    public string elat;
    public double elatJ2000;
    public double elong;
    public double elongJ2000;
    public double elongation;

    [JsonProperty(PropertyName = "elongation-deg")]
    public string elongation_deg;
    [JsonProperty(PropertyName = "elongation-dms")]
    public string elongation_dms;

    public bool found;
    public double glat;
    public double glong;

    [JsonProperty(PropertyName = "heliocentric-distance")]
    public double heliocentric_distance;
    [JsonProperty(PropertyName = "heliocentric-distance-km")]
    public double heliocentric_distance_km;
    [JsonProperty(PropertyName = "heliocentric-velocity")]
    public string heliocentric_velocity;
    [JsonProperty(PropertyName = "heliocentric-velocity-kms")]
    public double heliocentric_velocity_kms;
    [JsonProperty(PropertyName = "hourAngle-dd")]
    public double hourAngle_dd;
    [JsonProperty(PropertyName = "hourAngle-hms")]

    public string hourAngle_hms;
    public string iauConstellation;
    public double illumination;

    [JsonProperty(PropertyName = "is-waning")]
    public bool is_waning;
    [JsonProperty(PropertyName = "localized-name")]
    public string localized_name;

    public string meanSidTm;
    public string name;

    [JsonProperty(PropertyName = "object-type")]
    public string object_type;

    public double? pa_axis;
    public double parallacticAngle;
    public double phase;

    [JsonProperty(PropertyName = "phase-angle")]
    public double phase_angle;
    [JsonProperty(PropertyName = "phase-angle-deg")]
    public string phase_angle_deg;
    [JsonProperty(PropertyName = "phase-angle-dms")]
    public string phase_angle_dms;

    public double ra;
    public double raJ2000;
    public string rise;

    [JsonProperty(PropertyName = "rise-dhr")]
    public double rise_dhr;

    public int scale;
    public string set;

    [JsonProperty(PropertyName = "set-dhr")]
    public double set_dhr;

    public string sglat;
    public double sglong;
    public double size;

    [JsonProperty(PropertyName = "size-dd")]
    public double size_dd;
    [JsonProperty(PropertyName = "size-deg")]
    public string size_deg;
    [JsonProperty(PropertyName = "size-dms")]
    public string size_dms;

    public double subsolar_b;
    public double subsolar_l;
    public string transit;

    [JsonProperty(PropertyName = "transit-dhr")]
    public double transit_dhr;

    public string type;
    public string velocity;

    [JsonProperty(PropertyName = "velocity-kms")]
    public double velocity_kms;

    public double vmag;
    public double vmage;



}