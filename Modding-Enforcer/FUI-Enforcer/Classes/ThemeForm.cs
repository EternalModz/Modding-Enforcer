using System.ComponentModel;
using System.Windows.Forms;
using Dark.Net;

namespace FUI_Enforcer.Classes
{
    //The code found below has been written by Miku-666
    public class ThemeForm : Form
    {
        public ThemeForm(Theme theme)
            : base()
        {
            if (!DesignMode)
                DarkNet.Instance.SetWindowThemeForms(this, theme);
        }

        public ThemeForm()
            : this(Theme.Auto)
        {
        }

        public ThemeForm(IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}