namespace SteganographyApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.bmpResolutionLabel = new System.Windows.Forms.Label();
            this.bmpResolutionInfoLabel = new System.Windows.Forms.Label();
            this.sourceSizeLabel = new System.Windows.Forms.Label();
            this.sourceNameLabel = new System.Windows.Forms.Label();
            this.bmpSizeLabel = new System.Windows.Forms.Label();
            this.bmpNameLabel = new System.Windows.Forms.Label();
            this.sourceFileNameInfoLabel = new System.Windows.Forms.Label();
            this.sourceFileSizeInfoLabel = new System.Windows.Forms.Label();
            this.bmpFileSizeInfoLabel = new System.Windows.Forms.Label();
            this.bmpFileNameInfoLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.saveEncodedFileButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.selectSourceFileButton = new System.Windows.Forms.Button();
            this.beforeLabel = new System.Windows.Forms.Label();
            this.selectBmpFileButton = new System.Windows.Forms.Button();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.beforePictoreBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outcomePictureBox = new System.Windows.Forms.PictureBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.saveDecryptedFileButton = new System.Windows.Forms.Button();
            this.openDecryptedFileButton = new System.Windows.Forms.Button();
            this.decryptPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictoreBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outcomePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(-1, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(805, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.infoPictureBox);
            this.tabPage1.Controls.Add(this.bmpResolutionLabel);
            this.tabPage1.Controls.Add(this.bmpResolutionInfoLabel);
            this.tabPage1.Controls.Add(this.sourceSizeLabel);
            this.tabPage1.Controls.Add(this.sourceNameLabel);
            this.tabPage1.Controls.Add(this.bmpSizeLabel);
            this.tabPage1.Controls.Add(this.bmpNameLabel);
            this.tabPage1.Controls.Add(this.sourceFileNameInfoLabel);
            this.tabPage1.Controls.Add(this.sourceFileSizeInfoLabel);
            this.tabPage1.Controls.Add(this.bmpFileSizeInfoLabel);
            this.tabPage1.Controls.Add(this.bmpFileNameInfoLabel);
            this.tabPage1.Controls.Add(this.informationLabel);
            this.tabPage1.Controls.Add(this.afterLabel);
            this.tabPage1.Controls.Add(this.saveEncodedFileButton);
            this.tabPage1.Controls.Add(this.encodeButton);
            this.tabPage1.Controls.Add(this.selectSourceFileButton);
            this.tabPage1.Controls.Add(this.beforeLabel);
            this.tabPage1.Controls.Add(this.selectBmpFileButton);
            this.tabPage1.Controls.Add(this.afterPictureBox);
            this.tabPage1.Controls.Add(this.beforePictoreBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(667, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Source file view:";
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.infoPictureBox.Location = new System.Drawing.Point(646, 245);
            this.infoPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(119, 112);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPictureBox.TabIndex = 23;
            this.infoPictureBox.TabStop = false;
            // 
            // bmpResolutionLabel
            // 
            this.bmpResolutionLabel.AutoSize = true;
            this.bmpResolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmpResolutionLabel.Location = new System.Drawing.Point(684, 114);
            this.bmpResolutionLabel.Name = "bmpResolutionLabel";
            this.bmpResolutionLabel.Size = new System.Drawing.Size(43, 13);
            this.bmpResolutionLabel.TabIndex = 22;
            this.bmpResolutionLabel.Text = "         ";
            // 
            // bmpResolutionInfoLabel
            // 
            this.bmpResolutionInfoLabel.AutoSize = true;
            this.bmpResolutionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmpResolutionInfoLabel.Location = new System.Drawing.Point(597, 114);
            this.bmpResolutionInfoLabel.Name = "bmpResolutionInfoLabel";
            this.bmpResolutionInfoLabel.Size = new System.Drawing.Size(81, 13);
            this.bmpResolutionInfoLabel.TabIndex = 21;
            this.bmpResolutionInfoLabel.Text = "BMP resolution:";
            // 
            // sourceSizeLabel
            // 
            this.sourceSizeLabel.AutoSize = true;
            this.sourceSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sourceSizeLabel.Location = new System.Drawing.Point(684, 162);
            this.sourceSizeLabel.Name = "sourceSizeLabel";
            this.sourceSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.sourceSizeLabel.TabIndex = 20;
            this.sourceSizeLabel.Text = "             ";
            // 
            // sourceNameLabel
            // 
            this.sourceNameLabel.AutoSize = true;
            this.sourceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sourceNameLabel.Location = new System.Drawing.Point(692, 139);
            this.sourceNameLabel.Name = "sourceNameLabel";
            this.sourceNameLabel.Size = new System.Drawing.Size(51, 13);
            this.sourceNameLabel.TabIndex = 19;
            this.sourceNameLabel.Text = "           ";
            // 
            // bmpSizeLabel
            // 
            this.bmpSizeLabel.AutoSize = true;
            this.bmpSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmpSizeLabel.Location = new System.Drawing.Point(673, 91);
            this.bmpSizeLabel.Name = "bmpSizeLabel";
            this.bmpSizeLabel.Size = new System.Drawing.Size(43, 13);
            this.bmpSizeLabel.TabIndex = 18;
            this.bmpSizeLabel.Text = "         ";
            // 
            // bmpNameLabel
            // 
            this.bmpNameLabel.AutoSize = true;
            this.bmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmpNameLabel.Location = new System.Drawing.Point(681, 69);
            this.bmpNameLabel.Name = "bmpNameLabel";
            this.bmpNameLabel.Size = new System.Drawing.Size(43, 13);
            this.bmpNameLabel.TabIndex = 17;
            this.bmpNameLabel.Text = "         ";
            // 
            // sourceFileNameInfoLabel
            // 
            this.sourceFileNameInfoLabel.AutoSize = true;
            this.sourceFileNameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sourceFileNameInfoLabel.Location = new System.Drawing.Point(597, 139);
            this.sourceFileNameInfoLabel.Name = "sourceFileNameInfoLabel";
            this.sourceFileNameInfoLabel.Size = new System.Drawing.Size(89, 13);
            this.sourceFileNameInfoLabel.TabIndex = 16;
            this.sourceFileNameInfoLabel.Text = "Source file name:";
            // 
            // sourceFileSizeInfoLabel
            // 
            this.sourceFileSizeInfoLabel.AutoSize = true;
            this.sourceFileSizeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sourceFileSizeInfoLabel.Location = new System.Drawing.Point(597, 162);
            this.sourceFileSizeInfoLabel.Name = "sourceFileSizeInfoLabel";
            this.sourceFileSizeInfoLabel.Size = new System.Drawing.Size(81, 13);
            this.sourceFileSizeInfoLabel.TabIndex = 15;
            this.sourceFileSizeInfoLabel.Text = "Source file size:";
            // 
            // bmpFileSizeInfoLabel
            // 
            this.bmpFileSizeInfoLabel.AutoSize = true;
            this.bmpFileSizeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmpFileSizeInfoLabel.Location = new System.Drawing.Point(597, 91);
            this.bmpFileSizeInfoLabel.Name = "bmpFileSizeInfoLabel";
            this.bmpFileSizeInfoLabel.Size = new System.Drawing.Size(70, 13);
            this.bmpFileSizeInfoLabel.TabIndex = 14;
            this.bmpFileSizeInfoLabel.Text = "BMP file size:";
            // 
            // bmpFileNameInfoLabel
            // 
            this.bmpFileNameInfoLabel.AutoSize = true;
            this.bmpFileNameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmpFileNameInfoLabel.Location = new System.Drawing.Point(597, 69);
            this.bmpFileNameInfoLabel.Name = "bmpFileNameInfoLabel";
            this.bmpFileNameInfoLabel.Size = new System.Drawing.Size(78, 13);
            this.bmpFileNameInfoLabel.TabIndex = 13;
            this.bmpFileNameInfoLabel.Text = "BMP file name:";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informationLabel.Location = new System.Drawing.Point(642, 40);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(110, 20);
            this.informationLabel.TabIndex = 12;
            this.informationLabel.Text = "Informations";
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(336, 295);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(29, 13);
            this.afterLabel.TabIndex = 7;
            this.afterLabel.Text = "After";
            // 
            // saveEncodedFileButton
            // 
            this.saveEncodedFileButton.Location = new System.Drawing.Point(469, 332);
            this.saveEncodedFileButton.Name = "saveEncodedFileButton";
            this.saveEncodedFileButton.Size = new System.Drawing.Size(120, 25);
            this.saveEncodedFileButton.TabIndex = 6;
            this.saveEncodedFileButton.Text = "Save encoded file";
            this.saveEncodedFileButton.UseVisualStyleBackColor = true;
            this.saveEncodedFileButton.Click += new System.EventHandler(this.saveEncodedFileButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(321, 332);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(120, 25);
            this.encodeButton.TabIndex = 5;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // selectSourceFileButton
            // 
            this.selectSourceFileButton.Location = new System.Drawing.Point(169, 333);
            this.selectSourceFileButton.Name = "selectSourceFileButton";
            this.selectSourceFileButton.Size = new System.Drawing.Size(120, 25);
            this.selectSourceFileButton.TabIndex = 4;
            this.selectSourceFileButton.Text = "Select source file";
            this.selectSourceFileButton.UseVisualStyleBackColor = true;
            this.selectSourceFileButton.Click += new System.EventHandler(this.selectSourceFileButton_Click);
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Location = new System.Drawing.Point(17, 295);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(38, 13);
            this.beforeLabel.TabIndex = 3;
            this.beforeLabel.Text = "Before";
            // 
            // selectBmpFileButton
            // 
            this.selectBmpFileButton.BackColor = System.Drawing.Color.Transparent;
            this.selectBmpFileButton.Location = new System.Drawing.Point(20, 333);
            this.selectBmpFileButton.Name = "selectBmpFileButton";
            this.selectBmpFileButton.Size = new System.Drawing.Size(120, 25);
            this.selectBmpFileButton.TabIndex = 2;
            this.selectBmpFileButton.Text = "Select bmp file";
            this.selectBmpFileButton.UseVisualStyleBackColor = false;
            this.selectBmpFileButton.Click += new System.EventHandler(this.selectBmpFileButton_Click);
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.BackColor = System.Drawing.Color.Silver;
            this.afterPictureBox.Location = new System.Drawing.Point(339, 40);
            this.afterPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(250, 250);
            this.afterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.afterPictureBox.TabIndex = 1;
            this.afterPictureBox.TabStop = false;
            // 
            // beforePictoreBox
            // 
            this.beforePictoreBox.BackColor = System.Drawing.Color.Silver;
            this.beforePictoreBox.Location = new System.Drawing.Point(20, 40);
            this.beforePictoreBox.Margin = new System.Windows.Forms.Padding(5);
            this.beforePictoreBox.Name = "beforePictoreBox";
            this.beforePictoreBox.Size = new System.Drawing.Size(250, 250);
            this.beforePictoreBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beforePictoreBox.TabIndex = 0;
            this.beforePictoreBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outcomePictureBox);
            this.tabPage2.Controls.Add(this.decodeButton);
            this.tabPage2.Controls.Add(this.saveDecryptedFileButton);
            this.tabPage2.Controls.Add(this.openDecryptedFileButton);
            this.tabPage2.Controls.Add(this.decryptPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outcomePictureBox
            // 
            this.outcomePictureBox.BackColor = System.Drawing.Color.Silver;
            this.outcomePictureBox.Location = new System.Drawing.Point(437, 26);
            this.outcomePictureBox.Name = "outcomePictureBox";
            this.outcomePictureBox.Size = new System.Drawing.Size(300, 300);
            this.outcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outcomePictureBox.TabIndex = 4;
            this.outcomePictureBox.TabStop = false;
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(319, 332);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(140, 23);
            this.decodeButton.TabIndex = 3;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // saveDecryptedFileButton
            // 
            this.saveDecryptedFileButton.Location = new System.Drawing.Point(495, 332);
            this.saveDecryptedFileButton.Name = "saveDecryptedFileButton";
            this.saveDecryptedFileButton.Size = new System.Drawing.Size(140, 23);
            this.saveDecryptedFileButton.TabIndex = 2;
            this.saveDecryptedFileButton.Text = "Save decrypted file";
            this.saveDecryptedFileButton.UseVisualStyleBackColor = true;
            this.saveDecryptedFileButton.Click += new System.EventHandler(this.saveDecryptedFileButton_Click);
            // 
            // openDecryptedFileButton
            // 
            this.openDecryptedFileButton.Location = new System.Drawing.Point(149, 332);
            this.openDecryptedFileButton.Name = "openDecryptedFileButton";
            this.openDecryptedFileButton.Size = new System.Drawing.Size(140, 23);
            this.openDecryptedFileButton.TabIndex = 1;
            this.openDecryptedFileButton.Text = "Open encrypted file";
            this.openDecryptedFileButton.UseVisualStyleBackColor = true;
            this.openDecryptedFileButton.Click += new System.EventHandler(this.openAndDecryptFileButton_Click);
            // 
            // decryptPictureBox
            // 
            this.decryptPictureBox.BackColor = System.Drawing.Color.Silver;
            this.decryptPictureBox.Location = new System.Drawing.Point(82, 26);
            this.decryptPictureBox.Name = "decryptPictureBox";
            this.decryptPictureBox.Size = new System.Drawing.Size(300, 300);
            this.decryptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decryptPictureBox.TabIndex = 0;
            this.decryptPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SteganographyApp";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictoreBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outcomePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.Button selectBmpFileButton;
        private System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.PictureBox beforePictoreBox;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Button saveEncodedFileButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button selectSourceFileButton;
        private System.Windows.Forms.Button saveDecryptedFileButton;
        private System.Windows.Forms.Button openDecryptedFileButton;
        private System.Windows.Forms.PictureBox decryptPictureBox;
        private System.Windows.Forms.Label sourceFileNameInfoLabel;
        private System.Windows.Forms.Label sourceFileSizeInfoLabel;
        private System.Windows.Forms.Label bmpFileSizeInfoLabel;
        private System.Windows.Forms.Label bmpFileNameInfoLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label sourceSizeLabel;
        private System.Windows.Forms.Label sourceNameLabel;
        private System.Windows.Forms.Label bmpSizeLabel;
        private System.Windows.Forms.Label bmpNameLabel;
        private System.Windows.Forms.Label bmpResolutionLabel;
        private System.Windows.Forms.Label bmpResolutionInfoLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.PictureBox infoPictureBox;
        private System.Windows.Forms.PictureBox outcomePictureBox;
        private System.Windows.Forms.Label label1;
    }
}

