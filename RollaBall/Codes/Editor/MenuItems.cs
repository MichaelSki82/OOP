using UnityEditor;

namespace SkipinGame
{
    public class MenuItems
    {
        [MenuItem("SuperMenu/����� ���� �0 ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "SuperMenu");
        }



        [MenuItem("SuperMenu/����� ���� �1 ")]
       
        private static void MainMenuOption()
        {
            
        }

        [MenuItem("SuperMenu/����� ���� �2 %#a ")]
        private static void NewMenuOption()
        {
        }

        [MenuItem("SuperMenu/����� ���� �3 %g")]
        private static void NewNestedOption()
        {
        }

        [MenuItem("SuperMenu/����� ���� �4 _g")]
        private static void NewOptionWithHotkey()
        {
        }

        [MenuItem("SuperMenu/����� ����/����� ���� �3 _g")]
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

