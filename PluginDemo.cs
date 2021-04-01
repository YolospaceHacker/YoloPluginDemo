using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoloPlugins;


namespace YoloPluginDemo
{
    public class PluginDemo : YoloPlugin
    {
        public override string PluginName()
        {
            return "YoloPluginDemo";
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
            return PluginType.Task;
        }

        /*
        public override Image Image()
        {
            return null;
        }
        */

        YoloMainForm mainform;
        public override void OnInit(YoloMainForm f)
        {
            mainform = f;
            mainform.Log("Plugin demo Init", Level.info);
        }

        /*
        public override void OnClick()
        {
            
        }
        */
        public override void OnTerminate()
        {
            mainform.Log("Plugin demo Terminate", Level.info);
        }
    }

}
