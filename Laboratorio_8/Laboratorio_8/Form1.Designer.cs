namespace Laboratorio_8
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EveryStoreButton = new System.Windows.Forms.Button();
            this.StoreFinderButton = new System.Windows.Forms.Button();
            this.NewStoreButton = new System.Windows.Forms.Button();
            this.SSPanel = new System.Windows.Forms.Panel();
            this.SSTextBox = new System.Windows.Forms.TextBox();
            this.SSButton = new System.Windows.Forms.Button();
            this.SSLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DarkRed;
            this.MainPanel.Controls.Add(this.EveryStoreButton);
            this.MainPanel.Controls.Add(this.StoreFinderButton);
            this.MainPanel.Controls.Add(this.NewStoreButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // EveryStoreButton
            // 
            this.EveryStoreButton.BackColor = System.Drawing.SystemColors.Info;
            this.EveryStoreButton.Location = new System.Drawing.Point(272, 245);
            this.EveryStoreButton.Name = "EveryStoreButton";
            this.EveryStoreButton.Size = new System.Drawing.Size(219, 40);
            this.EveryStoreButton.TabIndex = 2;
            this.EveryStoreButton.Text = "Todos los locales";
            this.EveryStoreButton.UseVisualStyleBackColor = false;
            this.EveryStoreButton.Click += new System.EventHandler(this.EveryStoreButton_Click);
            // 
            // StoreFinderButton
            // 
            this.StoreFinderButton.BackColor = System.Drawing.SystemColors.Info;
            this.StoreFinderButton.Location = new System.Drawing.Point(272, 175);
            this.StoreFinderButton.Name = "StoreFinderButton";
            this.StoreFinderButton.Size = new System.Drawing.Size(219, 40);
            this.StoreFinderButton.TabIndex = 1;
            this.StoreFinderButton.Text = "Local existente";
            this.StoreFinderButton.UseVisualStyleBackColor = false;
            this.StoreFinderButton.Click += new System.EventHandler(this.StoreFinderButton_Click);
            // 
            // NewStoreButton
            // 
            this.NewStoreButton.BackColor = System.Drawing.SystemColors.Info;
            this.NewStoreButton.Location = new System.Drawing.Point(272, 105);
            this.NewStoreButton.Name = "NewStoreButton";
            this.NewStoreButton.Size = new System.Drawing.Size(219, 40);
            this.NewStoreButton.TabIndex = 0;
            this.NewStoreButton.Text = "Agregar nuevo local";
            this.NewStoreButton.UseVisualStyleBackColor = false;
            this.NewStoreButton.Click += new System.EventHandler(this.NewStoreButton_Click);
            // 
            // SSPanel
            // 
            this.SSPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SSPanel.Controls.Add(this.SSLabel);
            this.SSPanel.Controls.Add(this.SSButton);
            this.SSPanel.Controls.Add(this.SSTextBox);
            this.SSPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSPanel.Location = new System.Drawing.Point(0, 0);
            this.SSPanel.Name = "SSPanel";
            this.SSPanel.Size = new System.Drawing.Size(800, 450);
            this.SSPanel.TabIndex = 3;
            // 
            // SSTextBox
            // 
            this.SSTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SSTextBox.Location = new System.Drawing.Point(379, 171);
            this.SSTextBox.Name = "SSTextBox";
            this.SSTextBox.Size = new System.Drawing.Size(128, 22);
            this.SSTextBox.TabIndex = 0;
            // 
            // SSButton
            // 
            this.SSButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SSButton.Location = new System.Drawing.Point(563, 160);
            this.SSButton.Name = "SSButton";
            this.SSButton.Size = new System.Drawing.Size(93, 33);
            this.SSButton.TabIndex = 1;
            this.SSButton.Text = "Buscar";
            this.SSButton.UseVisualStyleBackColor = false;
            this.SSButton.Click += new System.EventHandler(this.SSButton_Click);
            // 
            // SSLabel
            // 
            this.SSLabel.AutoSize = true;
            this.SSLabel.BackColor = System.Drawing.SystemColors.Info;
            this.SSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSLabel.Location = new System.Drawing.Point(3, 175);
            this.SSLabel.Name = "SSLabel";
            this.SSLabel.Size = new System.Drawing.Size(314, 18);
            this.SSLabel.TabIndex = 2;
            this.SSLabel.Text = "Ingrese su busqueda (Dueño/Horario/Id):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SSPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.SSPanel.ResumeLayout(false);
            this.SSPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button EveryStoreButton;
        private System.Windows.Forms.Button StoreFinderButton;
        private System.Windows.Forms.Button NewStoreButton;
        private System.Windows.Forms.Panel SSPanel;
        private System.Windows.Forms.Label SSLabel;
        private System.Windows.Forms.Button SSButton;
        private System.Windows.Forms.TextBox SSTextBox;
    }
}

