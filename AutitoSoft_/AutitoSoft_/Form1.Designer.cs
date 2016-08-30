namespace AutitoSoft_
{
    partial class Form1
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
            this.setValue = new System.Windows.Forms.Button();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.DatastreamListBox = new System.Windows.Forms.ListBox();
            this.updateDatastreamsButton = new System.Windows.Forms.Button();
            this.picSet = new System.Windows.Forms.PictureBox();
            this.picStreams = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.estadoButton = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStreams)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setValue
            // 
            this.setValue.Location = new System.Drawing.Point(128, 116);
            this.setValue.Name = "setValue";
            this.setValue.Size = new System.Drawing.Size(75, 23);
            this.setValue.TabIndex = 1;
            this.setValue.Text = "Setear valor";
            this.setValue.UseVisualStyleBackColor = true;
            this.setValue.Click += new System.EventHandler(this.setValue_Click);
            // 
            // textBoxSet
            // 
            this.textBoxSet.Location = new System.Drawing.Point(22, 116);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.Size = new System.Drawing.Size(100, 20);
            this.textBoxSet.TabIndex = 2;
            // 
            // DatastreamListBox
            // 
            this.DatastreamListBox.FormattingEnabled = true;
            this.DatastreamListBox.Location = new System.Drawing.Point(22, 12);
            this.DatastreamListBox.Name = "DatastreamListBox";
            this.DatastreamListBox.Size = new System.Drawing.Size(120, 95);
            this.DatastreamListBox.TabIndex = 3;
            this.DatastreamListBox.SelectedIndexChanged += new System.EventHandler(this.DatastreamListBox_SelectedIndexChanged);
            // 
            // updateDatastreamsButton
            // 
            this.updateDatastreamsButton.Location = new System.Drawing.Point(148, 43);
            this.updateDatastreamsButton.Name = "updateDatastreamsButton";
            this.updateDatastreamsButton.Size = new System.Drawing.Size(75, 23);
            this.updateDatastreamsButton.TabIndex = 1;
            this.updateDatastreamsButton.Text = "Actualizar";
            this.updateDatastreamsButton.UseVisualStyleBackColor = true;
            this.updateDatastreamsButton.Click += new System.EventHandler(this.updateDatastreamsButton_Click);
            // 
            // picSet
            // 
            this.picSet.BackColor = System.Drawing.Color.Green;
            this.picSet.Location = new System.Drawing.Point(108, 116);
            this.picSet.Name = "picSet";
            this.picSet.Size = new System.Drawing.Size(14, 20);
            this.picSet.TabIndex = 4;
            this.picSet.TabStop = false;
            // 
            // picStreams
            // 
            this.picStreams.BackColor = System.Drawing.Color.Green;
            this.picStreams.Location = new System.Drawing.Point(126, 96);
            this.picStreams.Name = "picStreams";
            this.picStreams.Size = new System.Drawing.Size(16, 11);
            this.picStreams.TabIndex = 5;
            this.picStreams.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Azul";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // estadoButton
            // 
            this.estadoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estadoButton.Location = new System.Drawing.Point(231, 130);
            this.estadoButton.Name = "estadoButton";
            this.estadoButton.Size = new System.Drawing.Size(75, 23);
            this.estadoButton.TabIndex = 7;
            this.estadoButton.Text = "Comenzar";
            this.estadoButton.UseVisualStyleBackColor = true;
            this.estadoButton.Click += new System.EventHandler(this.estadoButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Verde";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 66);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 43);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 17);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Verde";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(15, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(45, 17);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Azul";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(256, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Izquierdo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Derecho";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.estadoButton);
            this.Controls.Add(this.picStreams);
            this.Controls.Add(this.picSet);
            this.Controls.Add(this.DatastreamListBox);
            this.Controls.Add(this.textBoxSet);
            this.Controls.Add(this.updateDatastreamsButton);
            this.Controls.Add(this.setValue);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStreams)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setValue;
        private System.Windows.Forms.TextBox textBoxSet;
        private System.Windows.Forms.ListBox DatastreamListBox;
        private System.Windows.Forms.Button updateDatastreamsButton;
        private System.Windows.Forms.PictureBox picSet;
        private System.Windows.Forms.PictureBox picStreams;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button estadoButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

