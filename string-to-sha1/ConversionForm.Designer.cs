namespace string_to_sha1
{
    partial class ConversionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.string_label = new System.Windows.Forms.Label();
            this.sha1_label = new System.Windows.Forms.Label();
            this.file_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.string_textbox = new System.Windows.Forms.TextBox();
            this.sha1_textbox = new System.Windows.Forms.TextBox();
            this.convertString_button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.convertFile_button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.open_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // string_label
            // 
            this.string_label.AutoSize = true;
            this.string_label.Location = new System.Drawing.Point(12, 9);
            this.string_label.Name = "string_label";
            this.string_label.Size = new System.Drawing.Size(41, 15);
            this.string_label.TabIndex = 0;
            this.string_label.Text = "String:";
            // 
            // sha1_label
            // 
            this.sha1_label.AutoSize = true;
            this.sha1_label.Location = new System.Drawing.Point(14, 38);
            this.sha1_label.Name = "sha1_label";
            this.sha1_label.Size = new System.Drawing.Size(39, 15);
            this.sha1_label.TabIndex = 1;
            this.sha1_label.Text = "SHA1:";
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(25, 96);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(28, 15);
            this.file_label.TabIndex = 2;
            this.file_label.Text = "File:";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(12, 125);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(44, 15);
            this.output_label.TabIndex = 3;
            this.output_label.Text = "Ouput:";
            // 
            // string_textbox
            // 
            this.string_textbox.Location = new System.Drawing.Point(59, 6);
            this.string_textbox.Name = "string_textbox";
            this.string_textbox.Size = new System.Drawing.Size(283, 23);
            this.string_textbox.TabIndex = 4;
            // 
            // sha1_textbox
            // 
            this.sha1_textbox.Location = new System.Drawing.Point(59, 35);
            this.sha1_textbox.Name = "sha1_textbox";
            this.sha1_textbox.Size = new System.Drawing.Size(283, 23);
            this.sha1_textbox.TabIndex = 5;
            // 
            // convertString_button
            // 
            this.convertString_button.Location = new System.Drawing.Point(59, 64);
            this.convertString_button.Name = "convertString_button";
            this.convertString_button.Size = new System.Drawing.Size(283, 23);
            this.convertString_button.TabIndex = 6;
            this.convertString_button.Text = "Convert String";
            this.convertString_button.UseVisualStyleBackColor = true;
            this.convertString_button.Click += new System.EventHandler(this.convertString_button_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // file_textbox
            // 
            this.file_textbox.Location = new System.Drawing.Point(59, 93);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.Size = new System.Drawing.Size(215, 23);
            this.file_textbox.TabIndex = 7;
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(59, 122);
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.Size = new System.Drawing.Size(215, 23);
            this.output_textbox.TabIndex = 8;
            // 
            // convertFile_button
            // 
            this.convertFile_button.Location = new System.Drawing.Point(59, 151);
            this.convertFile_button.Name = "convertFile_button";
            this.convertFile_button.Size = new System.Drawing.Size(283, 23);
            this.convertFile_button.TabIndex = 9;
            this.convertFile_button.Text = "Convert File";
            this.convertFile_button.UseVisualStyleBackColor = true;
            this.convertFile_button.Click += new System.EventHandler(this.convertFile_button_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 180);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 23);
            this.progressBar.TabIndex = 10;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(280, 92);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(62, 23);
            this.open_button.TabIndex = 11;
            this.open_button.Text = "Select";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(280, 122);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(62, 23);
            this.select_button.TabIndex = 12;
            this.select_button.Text = "Select";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 219);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.convertFile_button);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.file_textbox);
            this.Controls.Add(this.convertString_button);
            this.Controls.Add(this.sha1_textbox);
            this.Controls.Add(this.string_textbox);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.file_label);
            this.Controls.Add(this.sha1_label);
            this.Controls.Add(this.string_label);
            this.Name = "Form1";
            this.Text = "Convert to SHA1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label string_label;
        private Label sha1_label;
        private Label file_label;
        private Label output_label;
        private TextBox string_textbox;
        private TextBox sha1_textbox;
        private Button convertString_button;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TextBox file_textbox;
        private TextBox output_textbox;
        private Button convertFile_button;
        private ProgressBar progressBar;
        private Button open_button;
        private Button select_button;
    }
}