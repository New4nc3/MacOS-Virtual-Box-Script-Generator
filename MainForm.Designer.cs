namespace VirtualBoxMacOSScriptGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVBLocation = new System.Windows.Forms.Label();
            this.textBoxVBLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowseVBLocation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxListVirtualMachines = new System.Windows.Forms.ComboBox();
            this.radioButtonSelectFromList = new System.Windows.Forms.RadioButton();
            this.textBoxVBName = new System.Windows.Forms.TextBox();
            this.radioButtonInputManually = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxScriptName = new System.Windows.Forms.TextBox();
            this.checkBoxIsRunAfterGenerating = new System.Windows.Forms.CheckBox();
            this.radioButtonGenerateAsBat = new System.Windows.Forms.RadioButton();
            this.radioButtonGenerateAsTxt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVBLocation
            // 
            this.labelVBLocation.AutoSize = true;
            this.labelVBLocation.Location = new System.Drawing.Point(6, 22);
            this.labelVBLocation.Name = "labelVBLocation";
            this.labelVBLocation.Size = new System.Drawing.Size(104, 13);
            this.labelVBLocation.TabIndex = 0;
            this.labelVBLocation.Text = "Virtual Box Location:";
            // 
            // textBoxVBLocation
            // 
            this.textBoxVBLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVBLocation.Location = new System.Drawing.Point(116, 19);
            this.textBoxVBLocation.Name = "textBoxVBLocation";
            this.textBoxVBLocation.ReadOnly = true;
            this.textBoxVBLocation.Size = new System.Drawing.Size(350, 20);
            this.textBoxVBLocation.TabIndex = 1;
            // 
            // buttonBrowseVBLocation
            // 
            this.buttonBrowseVBLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseVBLocation.Location = new System.Drawing.Point(472, 17);
            this.buttonBrowseVBLocation.Name = "buttonBrowseVBLocation";
            this.buttonBrowseVBLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseVBLocation.TabIndex = 2;
            this.buttonBrowseVBLocation.Text = "Browse";
            this.buttonBrowseVBLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseVBLocation.Click += new System.EventHandler(this.ButtonBrowseVBLocation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelVBLocation);
            this.groupBox1.Controls.Add(this.buttonBrowseVBLocation);
            this.groupBox1.Controls.Add(this.textBoxVBLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Set Virtual Box Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxListVirtualMachines);
            this.groupBox2.Controls.Add(this.radioButtonSelectFromList);
            this.groupBox2.Controls.Add(this.textBoxVBName);
            this.groupBox2.Controls.Add(this.radioButtonInputManually);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Select Virtual Machine";
            // 
            // comboBoxListVirtualMachines
            // 
            this.comboBoxListVirtualMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListVirtualMachines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListVirtualMachines.FormattingEnabled = true;
            this.comboBoxListVirtualMachines.Location = new System.Drawing.Point(116, 45);
            this.comboBoxListVirtualMachines.Name = "comboBoxListVirtualMachines";
            this.comboBoxListVirtualMachines.Size = new System.Drawing.Size(431, 21);
            this.comboBoxListVirtualMachines.TabIndex = 3;
            this.comboBoxListVirtualMachines.SelectedIndexChanged += new System.EventHandler(this.ComboBoxListVirtualMachines_SelectedIndexChanged);
            // 
            // radioButtonSelectFromList
            // 
            this.radioButtonSelectFromList.AutoSize = true;
            this.radioButtonSelectFromList.Location = new System.Drawing.Point(9, 46);
            this.radioButtonSelectFromList.Name = "radioButtonSelectFromList";
            this.radioButtonSelectFromList.Size = new System.Drawing.Size(93, 17);
            this.radioButtonSelectFromList.TabIndex = 2;
            this.radioButtonSelectFromList.Text = "Select from list";
            this.radioButtonSelectFromList.UseVisualStyleBackColor = true;
            this.radioButtonSelectFromList.CheckedChanged += new System.EventHandler(this.RadioButtonSelectFromList_CheckedChanged);
            // 
            // textBoxVBName
            // 
            this.textBoxVBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVBName.Location = new System.Drawing.Point(116, 19);
            this.textBoxVBName.Name = "textBoxVBName";
            this.textBoxVBName.Size = new System.Drawing.Size(431, 20);
            this.textBoxVBName.TabIndex = 1;
            // 
            // radioButtonInputManually
            // 
            this.radioButtonInputManually.AutoSize = true;
            this.radioButtonInputManually.Location = new System.Drawing.Point(9, 20);
            this.radioButtonInputManually.Name = "radioButtonInputManually";
            this.radioButtonInputManually.Size = new System.Drawing.Size(93, 17);
            this.radioButtonInputManually.TabIndex = 0;
            this.radioButtonInputManually.Text = "Input manually";
            this.radioButtonInputManually.UseVisualStyleBackColor = true;
            this.radioButtonInputManually.CheckedChanged += new System.EventHandler(this.RadioButtonInputManually_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonGenerate);
            this.groupBox3.Controls.Add(this.buttonBrowse);
            this.groupBox3.Controls.Add(this.textBoxScriptName);
            this.groupBox3.Controls.Add(this.checkBoxIsRunAfterGenerating);
            this.groupBox3.Controls.Add(this.radioButtonGenerateAsBat);
            this.groupBox3.Controls.Add(this.radioButtonGenerateAsTxt);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 91);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Script Generation";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(472, 48);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 37);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(472, 19);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // textBoxScriptName
            // 
            this.textBoxScriptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxScriptName.Location = new System.Drawing.Point(116, 21);
            this.textBoxScriptName.Name = "textBoxScriptName";
            this.textBoxScriptName.Size = new System.Drawing.Size(350, 20);
            this.textBoxScriptName.TabIndex = 3;
            // 
            // checkBoxIsRunAfterGenerating
            // 
            this.checkBoxIsRunAfterGenerating.AutoSize = true;
            this.checkBoxIsRunAfterGenerating.Enabled = false;
            this.checkBoxIsRunAfterGenerating.Location = new System.Drawing.Point(30, 68);
            this.checkBoxIsRunAfterGenerating.Name = "checkBoxIsRunAfterGenerating";
            this.checkBoxIsRunAfterGenerating.Size = new System.Drawing.Size(123, 17);
            this.checkBoxIsRunAfterGenerating.TabIndex = 2;
            this.checkBoxIsRunAfterGenerating.Text = "Run after generating";
            this.checkBoxIsRunAfterGenerating.UseVisualStyleBackColor = true;
            this.checkBoxIsRunAfterGenerating.CheckedChanged += new System.EventHandler(this.CheckBoxIsRunAfterGenerating_CheckedChanged);
            // 
            // radioButtonGenerateAsBat
            // 
            this.radioButtonGenerateAsBat.AutoSize = true;
            this.radioButtonGenerateAsBat.Location = new System.Drawing.Point(9, 45);
            this.radioButtonGenerateAsBat.Name = "radioButtonGenerateAsBat";
            this.radioButtonGenerateAsBat.Size = new System.Drawing.Size(108, 17);
            this.radioButtonGenerateAsBat.TabIndex = 1;
            this.radioButtonGenerateAsBat.TabStop = true;
            this.radioButtonGenerateAsBat.Text = "Generate as *.bat";
            this.radioButtonGenerateAsBat.UseVisualStyleBackColor = true;
            this.radioButtonGenerateAsBat.CheckedChanged += new System.EventHandler(this.RadioButtonGenerateAsBat_CheckedChanged);
            // 
            // radioButtonGenerateAsTxt
            // 
            this.radioButtonGenerateAsTxt.AutoSize = true;
            this.radioButtonGenerateAsTxt.Location = new System.Drawing.Point(9, 22);
            this.radioButtonGenerateAsTxt.Name = "radioButtonGenerateAsTxt";
            this.radioButtonGenerateAsTxt.Size = new System.Drawing.Size(104, 17);
            this.radioButtonGenerateAsTxt.TabIndex = 0;
            this.radioButtonGenerateAsTxt.TabStop = true;
            this.radioButtonGenerateAsTxt.Text = "Generate as *.txt";
            this.radioButtonGenerateAsTxt.UseVisualStyleBackColor = true;
            this.radioButtonGenerateAsTxt.CheckedChanged += new System.EventHandler(this.RadioButtonGenerateAsTxt_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 247);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(4096, 286);
            this.MinimumSize = new System.Drawing.Size(593, 286);
            this.Name = "MainForm";
            this.Text = "Virtual Box Mac OS Script Generator by New4nc3__#";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVBLocation;
        private System.Windows.Forms.TextBox textBoxVBLocation;
        private System.Windows.Forms.Button buttonBrowseVBLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxListVirtualMachines;
        private System.Windows.Forms.RadioButton radioButtonSelectFromList;
        private System.Windows.Forms.TextBox textBoxVBName;
        private System.Windows.Forms.RadioButton radioButtonInputManually;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxScriptName;
        private System.Windows.Forms.CheckBox checkBoxIsRunAfterGenerating;
        private System.Windows.Forms.RadioButton radioButtonGenerateAsBat;
        private System.Windows.Forms.RadioButton radioButtonGenerateAsTxt;
    }
}

