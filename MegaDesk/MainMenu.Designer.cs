namespace MegaDesk
{
    public partial class MainMenu
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
            this.add_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(28, 35);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(169, 54);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "&Add New Quote";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(28, 95);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(169, 54);
            this.view_button.TabIndex = 1;
            this.view_button.Text = "&View Quotes";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(28, 155);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(169, 54);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "&Search Quotes";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(28, 215);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(169, 54);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "E&xit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 301);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.add_button);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button exit_button;
    }
}