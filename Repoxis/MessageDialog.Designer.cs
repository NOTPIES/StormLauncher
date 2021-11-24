
namespace Storm
{
    partial class MessageDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDialog));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.OKButton = new Guna.UI2.WinForms.Guna2Button();
            this.Title = new Guna.UI.WinForms.GunaLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.MessageText = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.VersionButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.VersionButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // OKButton
            // 
            this.OKButton.CheckedState.Parent = this.OKButton;
            this.OKButton.CustomImages.Parent = this.OKButton;
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.HoverState.Parent = this.OKButton;
            this.OKButton.Location = new System.Drawing.Point(435, 138);
            this.OKButton.Name = "OKButton";
            this.OKButton.ShadowDecoration.Parent = this.OKButton;
            this.OKButton.Size = new System.Drawing.Size(43, 33);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.Visible = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(3, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(490, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "{TITLE}";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.Title);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-4, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(496, 41);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.SystemColors.Control;
            this.MessageText.Location = new System.Drawing.Point(12, 61);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(73, 17);
            this.MessageText.TabIndex = 2;
            this.MessageText.Text = "{MESSAGE}";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.Title;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.TargetControl = this.MessageText;
            // 
            // VersionButton1
            // 
            this.VersionButton1.Animated = true;
            this.VersionButton1.CheckedState.Parent = this.VersionButton1;
            this.VersionButton1.CustomImages.Parent = this.VersionButton1;
            this.VersionButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VersionButton1.ForeColor = System.Drawing.Color.White;
            this.VersionButton1.HoverState.Parent = this.VersionButton1;
            this.VersionButton1.Location = new System.Drawing.Point(301, 138);
            this.VersionButton1.Name = "VersionButton1";
            this.VersionButton1.ShadowDecoration.Parent = this.VersionButton1;
            this.VersionButton1.Size = new System.Drawing.Size(92, 33);
            this.VersionButton1.TabIndex = 3;
            this.VersionButton1.Text = "Open Discord";
            this.VersionButton1.Visible = false;
            this.VersionButton1.Click += new System.EventHandler(this.VersionButton1_Click);
            // 
            // VersionButton2
            // 
            this.VersionButton2.Animated = true;
            this.VersionButton2.CheckedState.Parent = this.VersionButton2;
            this.VersionButton2.CustomImages.Parent = this.VersionButton2;
            this.VersionButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VersionButton2.ForeColor = System.Drawing.Color.White;
            this.VersionButton2.HoverState.Parent = this.VersionButton2;
            this.VersionButton2.Location = new System.Drawing.Point(399, 138);
            this.VersionButton2.Name = "VersionButton2";
            this.VersionButton2.ShadowDecoration.Parent = this.VersionButton2;
            this.VersionButton2.Size = new System.Drawing.Size(79, 33);
            this.VersionButton2.TabIndex = 4;
            this.VersionButton2.Text = "I\'ll do it later";
            this.VersionButton2.Visible = false;
            this.VersionButton2.Click += new System.EventHandler(this.VersionButton2_Click);
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(490, 183);
            this.Controls.Add(this.VersionButton2);
            this.Controls.Add(this.VersionButton1);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.MessageDialog_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI.WinForms.GunaLabel Title;
        public Guna.UI.WinForms.GunaLabel MessageText;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        public Guna.UI2.WinForms.Guna2Button VersionButton1;
        public Guna.UI2.WinForms.Guna2Button VersionButton2;
        public Guna.UI2.WinForms.Guna2Button OKButton;
    }
}