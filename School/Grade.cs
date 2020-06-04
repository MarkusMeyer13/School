using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    /// <summary>
    /// https://o7planning.org/de/10591/anleitung-csharp-delegate-und-event
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        public delegate void GradeSubmitHandler(string grade);

        // Die Definition eines Event. Es wird noch die Wert nicht übergetragen. 
        // Seine Wert wird vom außen übergetragen.
        public event GradeSubmitHandler GradeSubmitted;

        private void button1_Click(object sender, EventArgs e)
        {
            if (GradeSubmitted != null)
            {
                // Die Aufruf auf die Event-Behandlung
                GradeSubmitted(this.textBox1.Text);
            }
        }
    }
}
