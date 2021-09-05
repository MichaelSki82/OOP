using UnityEditor;

namespace SkipinGame
{
    public class MenuItems
    {
        [MenuItem("SuperMenu/Пункт меню №0 ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "SuperMenu");
        }



        [MenuItem("SuperMenu/Пункт меню №1 ")]
       
        private static void MainMenuOption()
        {
            
        }

        [MenuItem("SuperMenu/Пункт меню №2 %#a ")]
        private static void NewMenuOption()
        {
        }

        [MenuItem("SuperMenu/Пункт меню №3 %g")]
        private static void NewNestedOption()
        {
        }

        [MenuItem("SuperMenu/Пункт меню №4 _g")]
        private static void NewOptionWithHotkey()
        {
        }

        [MenuItem("SuperMenu/Пункт меню/Пункт меню №3 _g")]
        private static void NewOptionWithHot()
        {
        }

        [MenuItem("Assets/SuperMenu")]
        private static void LoadAdditiveScene()
        {
        }

        [MenuItem("Assets/Create/SuperMenu")]
        private static void AddConfig()
        {
        }
        [MenuItem("CONTEXT/Rigidbody/SuperMenu")]
        private static void NewOpenForRigidBody()
        {
        }



    }
}

