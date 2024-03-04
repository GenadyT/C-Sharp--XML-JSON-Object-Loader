using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developments
{
    public class DarkBlueButton : Button
    {
        public DarkBlueButton()
        {
            this.BackColor = Color.FromArgb(199, 199, 199);
            this.ForeColor = Color.DarkBlue;
            this.FlatAppearance.BorderColor = Color.DarkBlue;
            this.Cursor = Cursors.Hand;            
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }
    }
}
