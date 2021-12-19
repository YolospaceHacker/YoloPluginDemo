using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoloPlugins;
using System.Drawing;
using System.Windows.Forms;
using YoloPluginDemo.Properties;
using YoloPluginDemo;

namespace PluginToolbarDemo
{
    public class PluginToolbarDemo : YoloPlugin
    {
        public override string PluginName()
        {
            return "PluginToolbarDemo";
        }

        public override string Author()
        {
            return "Yop";
        }

        public override string Version()
        {
            return "0.1";
        }

        public override PluginType Type()
        {
            return PluginType.Toolbar;
        }

        public override Image Image()
        {
            return Resources.PluginToolbarIcon;
        }

        YoloMainForm mainform;


        Form form;
        YoloFormDemo formDemo;

        public override void OnInit(YoloMainForm f)
        {
            mainform = f;
            mainform.Log("Plugin Init", Level.info);

            form = f.NewFormURL("http://yolospacehacker.com");
            form.Hide();

            formDemo = new YoloFormDemo();
            formDemo.SetMainForm(f);
        }

        public override void OnClick()
        {
            mainform.Log("Plugin OnClick", Level.info);

            // Form url
            if (form.Visible)
            {
                form.Hide();
            }
            else
            {
                form.Show();
                form.TopMost = true;

            }

            // Form custom
            if (formDemo.Visible)
            {
                formDemo.Hide();
            }
            else
            {
                formDemo.Show();
                formDemo.TopMost = true;
            }
            
        }

        public override void OnTerminate()
        {

        }
    }


}
