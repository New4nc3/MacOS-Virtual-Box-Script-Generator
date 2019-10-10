using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VirtualBoxMacOSScriptGenerator
{
    public partial class MainForm : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private SaveFileDialog saveFileDialog;
        private Process getterVMList;
        private StreamWriter sw1;

        private List<string> listVM;
        private const string DEFAULT_PATH_VIRTUAL_BOX = @"C:\Program Files\Oracle\VirtualBox";

        public MainForm()
        {
            InitializeComponent();

            textBoxVBLocation.Text = Directory.Exists(DEFAULT_PATH_VIRTUAL_BOX) ? DEFAULT_PATH_VIRTUAL_BOX :
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            folderBrowserDialog = new FolderBrowserDialog();
            saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Text files (*.txt)|*.txt|Bat files (*.bat)|*.bat|All files (*.*)|*.*",
                FilterIndex = 3,
                RestoreDirectory = true,
                CheckPathExists = true
            };

            radioButtonGenerateAsTxt.Checked = true;
        }

        private void InitProcess()
        {
            getterVMList = new Process();
            getterVMList.StartInfo.UseShellExecute = false;
            getterVMList.StartInfo.RedirectStandardOutput = true;
            getterVMList.OutputDataReceived += new DataReceivedEventHandler(GetterListVM_newVMRecieved);

            getterVMList.StartInfo.FileName = $@"{textBoxVBLocation.Text}\VBoxManage.exe";
            getterVMList.StartInfo.Arguments = "list vms";

            getterVMList.Start();
            getterVMList.BeginOutputReadLine();

            getterVMList.WaitForExit();
        }

        private void InitRadioButtons()
        {
            if (File.Exists($@"{textBoxVBLocation.Text}\VBoxManage.exe"))
            {
                radioButtonSelectFromList.Enabled = true;
                radioButtonSelectFromList.Checked = true;

                listVM = new List<string>();

                InitProcess();
                RegisterVM();
            }
            else
            {
                radioButtonSelectFromList.Enabled = false;
                radioButtonInputManually.Checked = true;
            }
        }

        private void RegisterVM()
        {
            comboBoxListVirtualMachines.Items.Clear();

            foreach (var item in listVM)
                comboBoxListVirtualMachines.Items.Add(item);

            if (comboBoxListVirtualMachines.Items.Count > 0)
                comboBoxListVirtualMachines.SelectedIndex = 0;
        }

        private void GetterListVM_newVMRecieved(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string tempVMName =
                    new string(e.Data.Remove(0, 1)
                    .TakeWhile((x) => x != '"')
                    .ToArray());

                listVM.Add(tempVMName);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitRadioButtons();
        }

        private void ButtonBrowseVBLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK &&
                !folderBrowserDialog.SelectedPath.Equals(string.Empty))
            {
                textBoxVBLocation.Text = folderBrowserDialog.SelectedPath;

                InitRadioButtons();
            }
        }

        private void RadioButtonInputManually_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVBName.Enabled = radioButtonInputManually.Checked;
            comboBoxListVirtualMachines.Enabled = !radioButtonInputManually.Checked;
        }

        private void RadioButtonGenerateAsBat_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIsRunAfterGenerating.Enabled = radioButtonGenerateAsBat.Checked;
            saveFileDialog.FilterIndex = 2;
        }

        private void ComboBoxListVirtualMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxVBName.Text = comboBoxListVirtualMachines.SelectedItem.ToString();
        }

        private void CheckBoxIsRunAfterGenerating_CheckedChanged(object sender, EventArgs e)
        {
            buttonGenerate.Text = checkBoxIsRunAfterGenerating.Checked ? "Generate + Run" : "Generate";
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK &&
                !saveFileDialog.FileName.Equals(string.Empty))
            {
                textBoxScriptName.Text = saveFileDialog.FileName;
            }
        }

        private void RadioButtonGenerateAsTxt_CheckedChanged(object sender, EventArgs e)
        {
            saveFileDialog.FilterIndex = 1;
        }

        private void SaveFile(string filename)
        {
            using (sw1 = new StreamWriter(filename, false))
            {
                sw1.WriteLine($"cd \"{textBoxVBLocation.Text}\"");
                sw1.WriteLine($"VBoxManage.exe modifyvm \"{textBoxVBName.Text}\" --cpuidset 00000001 000106e5 00100800 0098e3fd bfebfbff");
                sw1.WriteLine($"VBoxManage setextradata \"{textBoxVBName.Text}\" \"VBoxInternal/Devices/efi/0/Config/DmiSystemProduct\" \"iMac11,3\"");
                sw1.WriteLine($"VBoxManage setextradata \"{textBoxVBName.Text}\" \"VBoxInternal/Devices/efi/0/Config/DmiSystemVersion\" \"1.0\"");
                sw1.WriteLine($"VBoxManage setextradata \"{textBoxVBName.Text}\" \"VBoxInternal/Devices/efi/0/Config/DmiBoardProduct\" \"Iloveapple\"");
                sw1.WriteLine($"VBoxManage setextradata \"{textBoxVBName.Text}\" \"VBoxInternal/Devices/smc/0/Config/DeviceKey\" \"ourhardworkbythesewordsguardedpleasedontsteal(c)AppleComputerInc\"");
                sw1.WriteLine($"VBoxManage setextradata \"{textBoxVBName.Text}\" \"VBoxInternal/Devices/smc/0/Config/GetKeyFromRealSMC\" 1");
                if (checkBoxIsRunAfterGenerating.Checked)
                    sw1.WriteLine($"echo Your Virtual Machine {textBoxVBName.Text} has been Successfully updated!" + Environment.NewLine + "pause");
            }
            MessageBox.Show($"File has been succesfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            string filename = textBoxScriptName.Text;
            if (!filename.Equals(string.Empty))
            {
                filename = textBoxScriptName.Text;

                SaveFile(filename);

                if(checkBoxIsRunAfterGenerating.Checked)
                    Process.Start(filename);
            }
            else
            {
                MessageBox.Show("Try to put something", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioButtonSelectFromList_CheckedChanged(object sender, EventArgs e)
        {
            textBoxVBName.Enabled = !radioButtonSelectFromList.Checked;
        }
    }
}
