using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterSheet.Character;
using DaanLib;

namespace CharacterSheet {
    public partial class CharacterForm : Form {
        public CharacterForm() {
            InitializeComponent();

            try {
                Sizes.GetSizeFromHeight(-1);
            } catch (ArgumentException ae) {
                Console.WriteLine(ae.Message);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Allows the user to move the window
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The Mouse Event Args of the event</param>
        private void bannerPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                NativeMethods.HandleWindowDrag(Handle);
        }
    }
}
