using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.Timeline;

public class LucesEscenaB : MonoBehaviour
{
    public Material[] materiales;
    public Vector4 luzdir;
    public Color colordir;

    public Vector4 luzspot;
    public Color colorspot;
    public Vector4 dirspot;
    //public Vector apertspot;

    public Vector4 luzpunt;
    public Color colorpunt;
    public Color ambientepunt;

    void Start()
    {   
        //DIRECCIONAL
        luzdir = new Vector4(0, 15, 0, 1);
        colordir = new Vector4(1, 1, 1, 1);

        //SPOT
        luzspot = new Vector4(-2, 2, 16, 1);
        colorspot = new Vector4(0.5f, 0.5f, 0.5f, 1);
        dirspot = new Vector4(0, -1, 0, 1);
        //apertspot = 1;

        //PUNTUAL
        luzpunt = new Vector4(1.7f, 0, 18, 0);
        colorpunt = new Vector4(1, 1, 1, 1);
        ambientepunt = new Vector4(1, 1, 1, 1);

        foreach(Material mat in materiales)
        {
            //DIRECCIONAL
            mat.SetColor("_DirectionalLightDirection", -luzdir);
            mat.SetColor("_DirectionalLightColor", colordir);

            //SPOT
            mat.SetColor("_SpotLightPosition_w", -luzspot);
            mat.SetColor("_SpotLightColor", colorspot);
            mat.SetColor("_SpotLightDirection", dirspot);
            //mat.SetColor("_Apertura", apertspot);

            //PUNTUAL
            mat.SetColor("_PointLightPosition_w", -luzpunt);
            mat.SetColor("_PointAmbientLight", colorpunt);
            mat.SetColor("_PointAmbientLight", ambientepunt);
        }   
    }

    void Update()
    {
        foreach(Material mat in materiales)
        {
            //DIRECCIONAL
            mat.SetColor("_DirectionalLightDirection", -luzdir);
            mat.SetColor("_DirectionalLightColor", colordir);

            //SPOT
            mat.SetColor("_SpotLightPosition_w", -luzspot);
            mat.SetColor("_SpotLightColor", colorspot);
            mat.SetColor("_SpotLightDirection", dirspot);

            //PUNTUAL
            mat.SetColor("_PointLightPosition_w", -luzpunt);
            mat.SetColor("_PointAmbientLight", colorpunt);
            mat.SetColor("_PointAmbientLight", ambientepunt);
        }
    }
}
