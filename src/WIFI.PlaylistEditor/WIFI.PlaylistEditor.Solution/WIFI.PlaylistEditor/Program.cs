using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using WIFI.PlaylistEditor.Factories;
using WIFI.PlaylistEditor.PlaylistCreators;
using WIFI.PlaylistEditor.Types;

namespace WIFI.PlaylistEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer();
            container.RegisterType<INewPlaylistCreator, DummyCreator>();
            container.RegisterType<IPlaylistItemFactory, PlaylistItemFactory>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve< EditorWindow>());
        }
    }
}
