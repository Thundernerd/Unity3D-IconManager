using TNRD.Utilities;

namespace UnityEngine
{
    public static class GameObjectExtensions
    {
        public static void SetIcon(this GameObject gameObject, LabelIcon labelIcon)
        {
            IconManager.SetIcon(gameObject, labelIcon);
        }

        public static void SetIcon(this GameObject gameObject, ShapeIcon shapeIcon)
        {
            IconManager.SetIcon(gameObject, shapeIcon);
        }

        public static void RemoveIcon(this GameObject gameObject)
        {
            IconManager.RemoveIcon(gameObject);
        }
    }
}