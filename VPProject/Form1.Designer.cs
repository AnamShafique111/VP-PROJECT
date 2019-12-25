namespace VPProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exitbutton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Convertbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Importbutton1 = new System.Windows.Forms.Button();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Exitbutton2 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Richtextboxpanel = new System.Windows.Forms.Panel();
            this.Savebutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Outputpanel = new System.Windows.Forms.Panel();
            this.OutputExitbutton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.TextradioButton = new System.Windows.Forms.RadioButton();
            this.RTFradioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.WordradioButton = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.Inputpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.JPGradioButton = new System.Windows.Forms.RadioButton();
            this.PNGradioButton = new System.Windows.Forms.RadioButton();
            this.PDFradioButton = new System.Windows.Forms.RadioButton();
            this.BMPradioButton = new System.Windows.Forms.RadioButton();
            this.TIFradioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonGIF = new System.Windows.Forms.RadioButton();
            this.selectformatbutton = new System.Windows.Forms.Button();
            this.ExitInputbutton = new System.Windows.Forms.Button();
            this.WMFradioButton = new System.Windows.Forms.RadioButton();
            this.JFIFradioButton = new System.Windows.Forms.RadioButton();
            this.EMFradioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.Richtextboxpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Outputpanel.SuspendLayout();
            this.Inputpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(171, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grab Text From Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VPProject.Properties.Resources.P21;
            this.pictureBox1.Location = new System.Drawing.Point(28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Exitbutton1
            // 
            this.Exitbutton1.BackColor = System.Drawing.SystemColors.Control;
            this.Exitbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton1.Location = new System.Drawing.Point(274, 462);
            this.Exitbutton1.Name = "Exitbutton1";
            this.Exitbutton1.Size = new System.Drawing.Size(81, 36);
            this.Exitbutton1.TabIndex = 5;
            this.Exitbutton1.Text = "Exit";
            this.Exitbutton1.UseVisualStyleBackColor = false;
            this.Exitbutton1.Click += new System.EventHandler(this.Exitbutton1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Convertbutton
            // 
            this.Convertbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Convertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convertbutton.Location = new System.Drawing.Point(28, 450);
            this.Convertbutton.Name = "Convertbutton";
            this.Convertbutton.Size = new System.Drawing.Size(322, 32);
            this.Convertbutton.TabIndex = 3;
            this.Convertbutton.Text = "Extract";
            this.Convertbutton.UseVisualStyleBackColor = false;
            this.Convertbutton.Click += new System.EventHandler(this.Convertbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.selectformatbutton);
            this.panel2.Controls.Add(this.Inputpanel);
            this.panel2.Controls.Add(this.pdfDocumentViewer1);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.Convertbutton);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 522);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Importbutton1
            // 
            this.Importbutton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Importbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Importbutton1.Location = new System.Drawing.Point(228, 290);
            this.Importbutton1.Name = "Importbutton1";
            this.Importbutton1.Size = new System.Drawing.Size(77, 35);
            this.Importbutton1.TabIndex = 29;
            this.Importbutton1.Text = "Import";
            this.Importbutton1.UseVisualStyleBackColor = false;
            this.Importbutton1.Click += new System.EventHandler(this.Importbutton1_Click_1);
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.AutoScroll = true;
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer1.FormFillEnabled = false;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(28, 92);
            this.pdfDocumentViewer1.MultiPagesThreshold = 60;
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous;
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(322, 344);
            this.pdfDocumentViewer1.TabIndex = 25;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage;
            this.pdfDocumentViewer1.Visible = false;
            this.pdfDocumentViewer1.ZoomFactor = 1F;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(28, 92);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(322, 344);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Exitbutton2
            // 
            this.Exitbutton2.BackColor = System.Drawing.SystemColors.Control;
            this.Exitbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton2.Location = new System.Drawing.Point(20, 450);
            this.Exitbutton2.Name = "Exitbutton2";
            this.Exitbutton2.Size = new System.Drawing.Size(125, 32);
            this.Exitbutton2.TabIndex = 8;
            this.Exitbutton2.Text = "Exit";
            this.Exitbutton2.UseVisualStyleBackColor = false;
            this.Exitbutton2.Click += new System.EventHandler(this.Exitbutton2_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(20, 49);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(335, 384);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // Richtextboxpanel
            // 
            this.Richtextboxpanel.BackColor = System.Drawing.Color.SpringGreen;
            this.Richtextboxpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Richtextboxpanel.Controls.Add(this.Savebutton);
            this.Richtextboxpanel.Controls.Add(this.Exitbutton2);
            this.Richtextboxpanel.Controls.Add(this.richTextBox);
            this.Richtextboxpanel.Location = new System.Drawing.Point(-2, -2);
            this.Richtextboxpanel.Name = "Richtextboxpanel";
            this.Richtextboxpanel.Size = new System.Drawing.Size(382, 522);
            this.Richtextboxpanel.TabIndex = 6;
            this.Richtextboxpanel.Visible = false;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.SystemColors.Control;
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(230, 450);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(125, 32);
            this.Savebutton.TabIndex = 9;
            this.Savebutton.Text = "Save as";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Richtextboxpanel);
            this.panel3.Controls.Add(this.Outputpanel);
            this.panel3.Controls.Add(this.Exitbutton1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(378, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 522);
            this.panel3.TabIndex = 6;
            // 
            // Outputpanel
            // 
            this.Outputpanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Outputpanel.Controls.Add(this.OutputExitbutton);
            this.Outputpanel.Controls.Add(this.buttonSave);
            this.Outputpanel.Controls.Add(this.TextradioButton);
            this.Outputpanel.Controls.Add(this.RTFradioButton);
            this.Outputpanel.Controls.Add(this.label2);
            this.Outputpanel.Controls.Add(this.WordradioButton);
            this.Outputpanel.Location = new System.Drawing.Point(20, 49);
            this.Outputpanel.Name = "Outputpanel";
            this.Outputpanel.Size = new System.Drawing.Size(324, 387);
            this.Outputpanel.TabIndex = 6;
            this.Outputpanel.Visible = false;
            // 
            // OutputExitbutton
            // 
            this.OutputExitbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputExitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputExitbutton.Location = new System.Drawing.Point(21, 332);
            this.OutputExitbutton.Name = "OutputExitbutton";
            this.OutputExitbutton.Size = new System.Drawing.Size(77, 36);
            this.OutputExitbutton.TabIndex = 11;
            this.OutputExitbutton.Text = "Exit";
            this.OutputExitbutton.UseVisualStyleBackColor = false;
            this.OutputExitbutton.Click += new System.EventHandler(this.OutputExitbutton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(227, 333);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(77, 36);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TextradioButton
            // 
            this.TextradioButton.AutoSize = true;
            this.TextradioButton.Location = new System.Drawing.Point(41, 158);
            this.TextradioButton.Name = "TextradioButton";
            this.TextradioButton.Size = new System.Drawing.Size(89, 19);
            this.TextradioButton.TabIndex = 4;
            this.TextradioButton.TabStop = true;
            this.TextradioButton.Text = "Plain Text";
            this.TextradioButton.UseVisualStyleBackColor = true;
            // 
            // RTFradioButton
            // 
            this.RTFradioButton.AutoSize = true;
            this.RTFradioButton.Location = new System.Drawing.Point(41, 133);
            this.RTFradioButton.Name = "RTFradioButton";
            this.RTFradioButton.Size = new System.Drawing.Size(120, 19);
            this.RTFradioButton.TabIndex = 3;
            this.RTFradioButton.TabStop = true;
            this.RTFradioButton.Text = "RTF Document";
            this.RTFradioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supported Output Formats:";
            // 
            // WordradioButton
            // 
            this.WordradioButton.AutoSize = true;
            this.WordradioButton.Location = new System.Drawing.Point(41, 108);
            this.WordradioButton.Name = "WordradioButton";
            this.WordradioButton.Size = new System.Drawing.Size(194, 19);
            this.WordradioButton.TabIndex = 0;
            this.WordradioButton.TabStop = true;
            this.WordradioButton.Text = " Microsoft Word Document";
            this.WordradioButton.UseVisualStyleBackColor = true;
            // 
            // Inputpanel
            // 
            this.Inputpanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Inputpanel.Controls.Add(this.EMFradioButton);
            this.Inputpanel.Controls.Add(this.JFIFradioButton);
            this.Inputpanel.Controls.Add(this.WMFradioButton);
            this.Inputpanel.Controls.Add(this.ExitInputbutton);
            this.Inputpanel.Controls.Add(this.radioButtonGIF);
            this.Inputpanel.Controls.Add(this.TIFradioButton);
            this.Inputpanel.Controls.Add(this.Importbutton1);
            this.Inputpanel.Controls.Add(this.BMPradioButton);
            this.Inputpanel.Controls.Add(this.PDFradioButton);
            this.Inputpanel.Controls.Add(this.PNGradioButton);
            this.Inputpanel.Controls.Add(this.textBox1);
            this.Inputpanel.Controls.Add(this.JPGradioButton);
            this.Inputpanel.Controls.Add(this.label3);
            this.Inputpanel.Location = new System.Drawing.Point(28, 92);
            this.Inputpanel.Name = "Inputpanel";
            this.Inputpanel.Size = new System.Drawing.Size(322, 344);
            this.Inputpanel.TabIndex = 31;
            this.Inputpanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supported Input Formats:";
            // 
            // JPGradioButton
            // 
            this.JPGradioButton.AutoSize = true;
            this.JPGradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPGradioButton.Location = new System.Drawing.Point(41, 108);
            this.JPGradioButton.Name = "JPGradioButton";
            this.JPGradioButton.Size = new System.Drawing.Size(90, 19);
            this.JPGradioButton.TabIndex = 3;
            this.JPGradioButton.TabStop = true;
            this.JPGradioButton.Text = "JPEG/JPG";
            this.JPGradioButton.UseVisualStyleBackColor = true;
            // 
            // PNGradioButton
            // 
            this.PNGradioButton.AutoSize = true;
            this.PNGradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNGradioButton.Location = new System.Drawing.Point(41, 131);
            this.PNGradioButton.Name = "PNGradioButton";
            this.PNGradioButton.Size = new System.Drawing.Size(54, 19);
            this.PNGradioButton.TabIndex = 4;
            this.PNGradioButton.TabStop = true;
            this.PNGradioButton.Text = "PNG";
            this.PNGradioButton.UseVisualStyleBackColor = true;
            // 
            // PDFradioButton
            // 
            this.PDFradioButton.AutoSize = true;
            this.PDFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFradioButton.Location = new System.Drawing.Point(41, 156);
            this.PDFradioButton.Name = "PDFradioButton";
            this.PDFradioButton.Size = new System.Drawing.Size(52, 19);
            this.PDFradioButton.TabIndex = 5;
            this.PDFradioButton.TabStop = true;
            this.PDFradioButton.Text = "PDF";
            this.PDFradioButton.UseVisualStyleBackColor = true;
            // 
            // BMPradioButton
            // 
            this.BMPradioButton.AutoSize = true;
            this.BMPradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMPradioButton.Location = new System.Drawing.Point(40, 181);
            this.BMPradioButton.Name = "BMPradioButton";
            this.BMPradioButton.Size = new System.Drawing.Size(55, 19);
            this.BMPradioButton.TabIndex = 7;
            this.BMPradioButton.TabStop = true;
            this.BMPradioButton.Text = "BMP";
            this.BMPradioButton.UseVisualStyleBackColor = true;
            // 
            // TIFradioButton
            // 
            this.TIFradioButton.AutoSize = true;
            this.TIFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIFradioButton.Location = new System.Drawing.Point(40, 206);
            this.TIFradioButton.Name = "TIFradioButton";
            this.TIFradioButton.Size = new System.Drawing.Size(77, 19);
            this.TIFradioButton.TabIndex = 8;
            this.TIFradioButton.TabStop = true;
            this.TIFradioButton.Text = "TIFF/TIF";
            this.TIFradioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonGIF
            // 
            this.radioButtonGIF.AutoSize = true;
            this.radioButtonGIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGIF.Location = new System.Drawing.Point(185, 108);
            this.radioButtonGIF.Name = "radioButtonGIF";
            this.radioButtonGIF.Size = new System.Drawing.Size(47, 19);
            this.radioButtonGIF.TabIndex = 10;
            this.radioButtonGIF.TabStop = true;
            this.radioButtonGIF.Text = "GIF";
            this.radioButtonGIF.UseVisualStyleBackColor = true;
            // 
            // selectformatbutton
            // 
            this.selectformatbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectformatbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectformatbutton.Location = new System.Drawing.Point(28, 49);
            this.selectformatbutton.Name = "selectformatbutton";
            this.selectformatbutton.Size = new System.Drawing.Size(322, 32);
            this.selectformatbutton.TabIndex = 32;
            this.selectformatbutton.Text = "Select Format";
            this.selectformatbutton.UseVisualStyleBackColor = false;
            this.selectformatbutton.Click += new System.EventHandler(this.selectformatbutton_Click);
            // 
            // ExitInputbutton
            // 
            this.ExitInputbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitInputbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitInputbutton.Location = new System.Drawing.Point(19, 290);
            this.ExitInputbutton.Name = "ExitInputbutton";
            this.ExitInputbutton.Size = new System.Drawing.Size(77, 36);
            this.ExitInputbutton.TabIndex = 30;
            this.ExitInputbutton.Text = "Exit";
            this.ExitInputbutton.UseVisualStyleBackColor = false;
            this.ExitInputbutton.Click += new System.EventHandler(this.ExitInputbutton_Click);
            // 
            // WMFradioButton
            // 
            this.WMFradioButton.AutoSize = true;
            this.WMFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WMFradioButton.Location = new System.Drawing.Point(185, 131);
            this.WMFradioButton.Name = "WMFradioButton";
            this.WMFradioButton.Size = new System.Drawing.Size(57, 19);
            this.WMFradioButton.TabIndex = 31;
            this.WMFradioButton.TabStop = true;
            this.WMFradioButton.Text = "WMF";
            this.WMFradioButton.UseVisualStyleBackColor = true;
            // 
            // JFIFradioButton
            // 
            this.JFIFradioButton.AutoSize = true;
            this.JFIFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JFIFradioButton.Location = new System.Drawing.Point(185, 156);
            this.JFIFradioButton.Name = "JFIFradioButton";
            this.JFIFradioButton.Size = new System.Drawing.Size(52, 19);
            this.JFIFradioButton.TabIndex = 32;
            this.JFIFradioButton.TabStop = true;
            this.JFIFradioButton.Text = "JFIF";
            this.JFIFradioButton.UseVisualStyleBackColor = true;
            // 
            // EMFradioButton
            // 
            this.EMFradioButton.AutoSize = true;
            this.EMFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMFradioButton.Location = new System.Drawing.Point(185, 181);
            this.EMFradioButton.Name = "EMFradioButton";
            this.EMFradioButton.Size = new System.Drawing.Size(54, 19);
            this.EMFradioButton.TabIndex = 33;
            this.EMFradioButton.TabStop = true;
            this.EMFradioButton.Text = "EMF";
            this.EMFradioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(759, 627);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.Richtextboxpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Outputpanel.ResumeLayout(false);
            this.Outputpanel.PerformLayout();
            this.Inputpanel.ResumeLayout(false);
            this.Inputpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Convertbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exitbutton2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel Richtextboxpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Panel Outputpanel;
        private System.Windows.Forms.RadioButton TextradioButton;
        private System.Windows.Forms.RadioButton RTFradioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton WordradioButton;
        private System.Windows.Forms.Button Importbutton1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button OutputExitbutton;
        private System.Windows.Forms.Panel Inputpanel;
        private System.Windows.Forms.RadioButton TIFradioButton;
        private System.Windows.Forms.RadioButton BMPradioButton;
        private System.Windows.Forms.RadioButton PDFradioButton;
        private System.Windows.Forms.RadioButton PNGradioButton;
        private System.Windows.Forms.RadioButton JPGradioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonGIF;
        private System.Windows.Forms.Button selectformatbutton;
        private System.Windows.Forms.Button ExitInputbutton;
        private System.Windows.Forms.RadioButton WMFradioButton;
        private System.Windows.Forms.RadioButton JFIFradioButton;
        private System.Windows.Forms.RadioButton EMFradioButton;
    }
}

