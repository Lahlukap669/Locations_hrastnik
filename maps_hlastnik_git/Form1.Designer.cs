namespace maps_hlastnik
{
    partial class Map_form
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.Label_1 = new System.Windows.Forms.Label();
            this.StartLocation = new System.Windows.Forms.TextBox();
            this.Load_Location = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EndLocation = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(236, 465);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(242, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(572, 465);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(13, 9);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(86, 13);
            this.Label_1.TabIndex = 2;
            this.Label_1.Text = "Začetna lokacija";
            // 
            // StartLocation
            // 
            this.StartLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.StartLocation.Location = new System.Drawing.Point(16, 25);
            this.StartLocation.Name = "StartLocation";
            this.StartLocation.Size = new System.Drawing.Size(206, 24);
            this.StartLocation.TabIndex = 3;
            // 
            // Load_Location
            // 
            this.Load_Location.Location = new System.Drawing.Point(16, 112);
            this.Load_Location.Name = "Load_Location";
            this.Load_Location.Size = new System.Drawing.Size(206, 36);
            this.Load_Location.TabIndex = 4;
            this.Load_Location.Text = "Najdi";
            this.Load_Location.UseVisualStyleBackColor = true;
            this.Load_Location.Click += new System.EventHandler(this.Load_Location_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Končna lokacija";
            // 
            // EndLocation
            // 
            this.EndLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EndLocation.Location = new System.Drawing.Point(16, 73);
            this.EndLocation.Name = "EndLocation";
            this.EndLocation.Size = new System.Drawing.Size(206, 24);
            this.EndLocation.TabIndex = 6;
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.Display.FormattingEnabled = true;
            this.Display.Location = new System.Drawing.Point(16, 191);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(206, 199);
            this.Display.TabIndex = 7;
            // 
            // Map_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 465);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.EndLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load_Location);
            this.Controls.Add(this.StartLocation);
            this.Controls.Add(this.Label_1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.splitter1);
            this.Name = "Map_form";
            this.Text = "Zemljevid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.TextBox StartLocation;
        private System.Windows.Forms.Button Load_Location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EndLocation;
        private System.Windows.Forms.ListBox Display;
    }
}

