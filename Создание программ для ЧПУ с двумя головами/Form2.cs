using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Создание_программ_для_ЧПУ_с_двумя_головами
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public bool SetupIsDone = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                MessageBox.Show("По завершению установки укажите путь к NC Corrector в соответсвующем пункте меню настроек");
                
                Hide();
                Process setup = Process.Start(AppContext.BaseDirectory + "nc4_setup.exe");
                setup.WaitForExit();
                Show();
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SetupIsDone = true;
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetupIsDone = true;
            Form2.ActiveForm.Close();
            
        }
    }
}
