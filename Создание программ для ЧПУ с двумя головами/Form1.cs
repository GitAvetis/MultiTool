using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace Создание_программ_для_ЧПУ_с_двумя_головами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxFirstProgrammName.Text = openFileDialog1.FileName;
            TextBoxSecondProgrammName.Text = openFileDialog2.FileName;
            TextBoxResultName.Text = "new file";
            ToolTip tp = new ToolTip();
            tp.SetToolTip(button, openFileDialog1.FileName);
            tp.SetToolTip(button2, openFileDialog2.FileName);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBoxResultName.TextLength != 0)
            {
               
                folderBrowserDialog1.ShowDialog();
                string path = AppContext.BaseDirectory;

                string folder = folderBrowserDialog1.SelectedPath;
                bool nameIsAvalible = false;
                int i = 1;
                while (nameIsAvalible != true)
                {
                    
                    if (File.Exists(folder + $"\\{TextBoxResultName.Text}.NC"))
                    {
                        TextBoxResultName.Text = $"new file({i})";
                        i++;
                    }
                    else
                        nameIsAvalible = true;

                }
                string resultFileName = folder + "\\" + TextBoxResultName.Text + ".NC";
                
                string[] pattern = File.ReadAllLines("Шаблон.txt");
                string[] firstCode = File.ReadAllLines(openFileDialog1.FileName);
                string[] secondCode = File.ReadAllLines(openFileDialog2.FileName);

                if (File.Exists(openFileDialog1.FileName) != true || File.Exists(openFileDialog2.FileName) !=true)
                    MessageBox.Show("Неправильно указан путь к одному из выбранных файлов");
                else if (File.Exists("Шаблон.txt") != true)
                    MessageBox.Show("Отсутсвует файл '\'Шаблон'\'");
                else
                {
                    string[] firstCodeAfterCut = firstCode.SkipWhile(x => x.StartsWith("G0") != true)
                                                     .TakeWhile(x => x.StartsWith("M") != true)
                                                     .ToArray();

                    string[] secondCodeAfterCut = secondCode.SkipWhile(x => x.StartsWith("G0") != true)
                                                            .TakeWhile(x => x.StartsWith("M") != true)
                                                            .ToArray();

                    string[] firstPatternPart = pattern.TakeWhile(x => x.StartsWith(" ") != true)
                                                            .ToArray();

                    string[] secondPatternPart = pattern.SkipWhile(x => x.StartsWith("M06 T2") != true)
                                                        .TakeWhile(x => x.StartsWith(" ") != true)
                                                        .ToArray();

                    string[] lastPatterPart = pattern.SkipWhile(x => x.StartsWith("G80") != true)
                                                     .Select(x => x)
                                                     .ToArray();
                    if (File.Exists(resultFileName) == true)
                    {
                        MessageBox.Show("Измените имя файла или место его сохранения. Файл с указанным именем уже существует в выбранной вами директории");
                    }
                    else
                    {
                        File.AppendAllLines(resultFileName, firstPatternPart);
                        File.AppendAllLines(resultFileName, firstCodeAfterCut);
                        File.AppendAllText(resultFileName, "M5\n");
                        File.AppendAllLines(resultFileName, secondPatternPart);
                        File.AppendAllLines(resultFileName, secondCodeAfterCut);
                        File.AppendAllLines(resultFileName, lastPatterPart);
  
                        ToolTip tp = new ToolTip();
                        tp.SetToolTip(button3, resultFileName);
                        tp.SetToolTip(TextBoxResultName, resultFileName);
                    }
                    Process NCOpening = new Process();
                    Process savingFolderOpen = new Process();
                    if (checkBox1.Checked)
                    {
                       string NCCPath;
                       try { NCCPath = File.ReadAllText("pathForNCC.txt"); }
                       catch
                       {
                           NCCPath = File.ReadAllText("pathForNCC");
                       }
                       try 
                       { 
                            NCOpening = Process.Start(NCCPath, resultFileName);
                            NCOpening.WaitForExit();
                           
                       }
                       catch 
                       {
                           Hide();
                           Form2 form2 = new Form2();
                           form2.ShowDialog();
                           if (form2.SetupIsDone == true)
                           Show();
                       }
         
                    } 

                    savingFolderOpen = Process.Start("explorer.exe", folder);
                }
            }
            else
            {
                MessageBox.Show("Вы не указали имя создаваемого файла");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            int n = openFileDialog2.FileName.Split('\\').Length;
            TextBoxSecondProgrammName.Text = openFileDialog2.FileName.Split('\\')[n-1];
            ToolTip tp = new ToolTip();
            tp.SetToolTip(button2, openFileDialog2.FileName);
            tp.SetToolTip(TextBoxSecondProgrammName, openFileDialog2.FileName);

        }

        private void button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            int n = openFileDialog1.FileName.Split('\\').Length;
            TextBoxFirstProgrammName.Text = openFileDialog1.FileName.Split('\\')[n-1];
            ToolTip tp = new ToolTip();
            tp.SetToolTip(button, openFileDialog1.FileName);
            tp.SetToolTip(TextBoxFirstProgrammName, openFileDialog1.FileName);
            
        }

        private void nCCorrectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                MessageBox.Show("По завершению установки укажите путь к NC Corrector в соответсвующем пункте меню настроек");
                Process.Start(AppContext.BaseDirectory + "nc4_setup.exe"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            int n = openFileDialog4.FileName.Split('\\').Length;
            if(openFileDialog4.FileName.Equals("Путь к NC Corrector") != true)
            {
                string _NCCPath = openFileDialog4.FileName;
                try { File.WriteAllText("pathForNCC.txt", _NCCPath); }
                catch
                {
                    File.WriteAllText("pathForNCC", _NCCPath);
                }
            }
            else
            {
                MessageBox.Show("Операция была отменена");
            }
           
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string description;
            try { description = File.ReadAllText("Справка.txt"); }
            catch
            {
                description = File.ReadAllText("Справка");
            }
            MessageBox.Show(description);
        }

 
    }
}
