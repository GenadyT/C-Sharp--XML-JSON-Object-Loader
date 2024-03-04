namespace Developments
{
    partial class frmFileManagerTest
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
            btnReadTextRows = new DarkBlueButton();
            tbxTextFileRows = new TextBox();
            tbxObjectFromXml = new TextBox();
            btnReadXmlObject = new DarkBlueButton();
            tbxObjectFromJson = new TextBox();
            btnReadJsonObject = new DarkBlueButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnReadTextRows
            // 
            btnReadTextRows.BackColor = Color.FromArgb(222, 222, 222);
            btnReadTextRows.FlatStyle = FlatStyle.Flat;
            btnReadTextRows.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReadTextRows.ForeColor = Color.DarkBlue;
            btnReadTextRows.Location = new Point(463, 74);
            btnReadTextRows.Name = "btnReadTextRows";
            btnReadTextRows.Size = new Size(200, 25);
            btnReadTextRows.TabIndex = 4;
            btnReadTextRows.Text = "Read Text Rows (music genres)";
            btnReadTextRows.UseVisualStyleBackColor = false;
            btnReadTextRows.Click += btnReadTextRows_Click;
            // 
            // tbxTextFileRows
            // 
            tbxTextFileRows.Location = new Point(463, 111);
            tbxTextFileRows.Multiline = true;
            tbxTextFileRows.Name = "tbxTextFileRows";
            tbxTextFileRows.ScrollBars = ScrollBars.Vertical;
            tbxTextFileRows.Size = new Size(198, 287);
            tbxTextFileRows.TabIndex = 1;
            // 
            // tbxObjectFromXml
            // 
            tbxObjectFromXml.Location = new Point(24, 111);
            tbxObjectFromXml.Multiline = true;
            tbxObjectFromXml.Name = "tbxObjectFromXml";
            tbxObjectFromXml.ScrollBars = ScrollBars.Vertical;
            tbxObjectFromXml.Size = new Size(199, 287);
            tbxObjectFromXml.TabIndex = 3;
            // 
            // btnReadXmlObject
            // 
            btnReadXmlObject.BackColor = Color.FromArgb(199, 199, 199);
            btnReadXmlObject.FlatStyle = FlatStyle.Flat;
            btnReadXmlObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReadXmlObject.ForeColor = Color.DarkBlue;
            btnReadXmlObject.Location = new Point(24, 74);
            btnReadXmlObject.Name = "btnReadXmlObject";
            btnReadXmlObject.Size = new Size(200, 25);
            btnReadXmlObject.TabIndex = 1;
            btnReadXmlObject.Text = "Load Object from Xml  (music genres)";
            btnReadXmlObject.UseVisualStyleBackColor = true;
            btnReadXmlObject.Click += btnReadXmlObject_Click;
            // 
            // tbxObjectFromJson
            // 
            tbxObjectFromJson.Location = new Point(242, 111);
            tbxObjectFromJson.Multiline = true;
            tbxObjectFromJson.Name = "tbxObjectFromJson";
            tbxObjectFromJson.ScrollBars = ScrollBars.Vertical;
            tbxObjectFromJson.Size = new Size(200, 287);
            tbxObjectFromJson.TabIndex = 5;
            // 
            // btnReadJsonObject
            // 
            btnReadJsonObject.BackColor = Color.FromArgb(199, 199, 199);
            btnReadJsonObject.FlatStyle = FlatStyle.Flat;
            btnReadJsonObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReadJsonObject.ForeColor = Color.DarkBlue;
            btnReadJsonObject.Location = new Point(242, 74);
            btnReadJsonObject.Name = "btnReadJsonObject";
            btnReadJsonObject.Size = new Size(200, 25);
            btnReadJsonObject.TabIndex = 2;
            btnReadJsonObject.Text = "Load Object from Json  (music genres)";
            btnReadJsonObject.UseVisualStyleBackColor = true;
            btnReadJsonObject.Click += btnReadJsonObject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(636, 31);
            label1.TabIndex = 6;
            label1.Text = "the objects data is inspired by \"Music Genres\" theme ..." +
                "                                                            ";
            // 
            // frmFileManagerTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 422);
            Controls.Add(label1);
            Controls.Add(tbxObjectFromJson);
            Controls.Add(btnReadJsonObject);
            Controls.Add(tbxObjectFromXml);
            Controls.Add(btnReadXmlObject);
            Controls.Add(tbxTextFileRows);
            Controls.Add(btnReadTextRows);
            Name = "frmFileManagerTest";
            Text = "Load objects from the three source types - Text, XML and Json";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxTextFileRows;
        private TextBox tbxObjectFromXml;
        private TextBox tbxObjectFromJson;
        private DarkBlueButton btnReadTextRows;
        private DarkBlueButton btnReadXmlObject;
        private DarkBlueButton btnReadJsonObject;
        private Label label1;
    }
}