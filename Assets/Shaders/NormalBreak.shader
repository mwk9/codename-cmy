﻿// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/NormalBreak"
{
	Properties
	{
		_MainTex("MainTex", 2D) = "white" {}
		_Outline("Outline Width", float) = 0
		_Color("Outline Color", Color) = (1, 1, 1, 1)
	}

	SubShader
	{
		Pass
		{
			Tags
			{
				"RenderType" = "Opaque"
			}
			Cull Front

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float3 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				float3 uv : TEXCOORD0;
			};

			float _Outline;
			float4 _Color;

			float4 vert(appdata_base v) : SV_POSITION
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				float3 normal = mul((float3x3) UNITY_MATRIX_MV, v.normal);
				normal.x *= UNITY_MATRIX_P[0][0];
				normal.y *= UNITY_MATRIX_P[1][1];
				o.vertex.xy += normal.xy * _Outline;
				return o.vertex;
			}

			half4 frag(v2f i) : COLOR
			{
				return _Color;
			}

			ENDCG
		}
	}
}