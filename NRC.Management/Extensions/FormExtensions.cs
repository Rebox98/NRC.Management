using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRC.Management.Extensions
{
    public static class FormExtensions
    {
        public static void InvokeUI(this Form from, Action call)
        {
            if (from.IsDisposed) return;
            if (from.InvokeRequired)
                try { from.Invoke(call); }
                catch (InvalidOperationException ex) { }
            else call();
        }
    }
}
