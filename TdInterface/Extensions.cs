using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TdInterface
{
    public static class Extensions
    {
        public static void InvokeIfRequired(this ISynchronizeInvoke obj, MethodInvoker action)
        {
            try
            {
                if (obj != null && obj.InvokeRequired)
                {
                    var args = new object[0];
                    obj.Invoke(action, args);
                }
                else
                {
                    action();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static void SafeUpdateControl(Control sender, string text)
        {
            try
            {
                sender.InvokeIfRequired(() =>
                {
                    // Do anything you want with the control here
                    sender.Text = text;
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static void SafeUpdateControlTag(Control sender, string tag)
        {
            try
            {
                sender.InvokeIfRequired(() =>
                {
                    // Do anything you want with the control here
                    sender.Tag = tag;
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
