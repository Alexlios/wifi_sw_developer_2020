using Playlist;
using PlaylistWindow.PlaylistCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PlaylistWindow
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

            //Typen registrieren
            container.RegisterType<INewPlaylistCreator, DummyCreator>();
            container.RegisterType<IPlaylistItemFactory, PlaylistItemFactory>();

            //applikation start
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Form1>());
        }
    }
}
