using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace TNRD.Utilities
{
    public static class IconManager
    {
        private static MethodInfo setIconForObjectMethodInfo;

        public static void SetIcon(GameObject gameObject, LabelIcon labelIcon)
        {
            SetIcon(gameObject, $"sv_label_{(int) labelIcon}");
        }

        public static void SetIcon(GameObject gameObject, ShapeIcon shapeIcon)
        {
            SetIcon(gameObject, $"sv_icon_dot{(int) shapeIcon}_pix16_gizmo");
        }

        private static void SetIcon(GameObject gameObject, string contentName)
        {
            GUIContent iconContent = EditorGUIUtility.IconContent(contentName);
            SetIconForObject(gameObject, (Texture2D) iconContent.image);
        }

        public static void RemoveIcon(GameObject gameObject)
        {
            SetIconForObject(gameObject, null);
        }

        public static void SetIconForObject(GameObject obj, Texture2D icon)
        {
#if UNITY_2021_2_OR_NEWER
            EditorGUIUtility.SetIconForObject(obj, icon);
#else
            if (setIconForObjectMethodInfo == null)
            {
                Type type = typeof(EditorGUIUtility);
                setIconForObjectMethodInfo =
                    type.GetMethod("SetIconForObject", BindingFlags.Static | BindingFlags.NonPublic);
            }

            setIconForObjectMethodInfo.Invoke(null, new object[] {obj, icon});
#endif
        }
    }
}
