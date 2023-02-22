
namespace UniEats_Alpha
{
    partial class ViewRestaurants
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
            this.RestaurantBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shopButtonClick1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.RestaurantBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.RestaurantBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RestaurantBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RestaurantBox1
            // 
            this.RestaurantBox1.Controls.Add(this.label4);
            this.RestaurantBox1.Controls.Add(this.label3);
            this.RestaurantBox1.Controls.Add(this.pictureBox1);
            this.RestaurantBox1.Controls.Add(this.label2);
            this.RestaurantBox1.Controls.Add(this.label1);
            this.RestaurantBox1.Controls.Add(this.shopButtonClick1);
            this.RestaurantBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurantBox1.Location = new System.Drawing.Point(75, 202);
            this.RestaurantBox1.Name = "RestaurantBox1";
            this.RestaurantBox1.Size = new System.Drawing.Size(502, 316);
            this.RestaurantBox1.TabIndex = 0;
            this.RestaurantBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Spar On-campus Shop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 100);
            this.label3.TabIndex = 4;
            this.label3.Text = "Services offered:\r\nBaked Goods\r\nFresh food \r\nFresh fruit and vegetables";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UniEats_Alpha.Properties.Resources.sparHull;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(248, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 224);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delivery Estimate:\r\n10-30 Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delivery Charge: \r\n£0.99";
            // 
            // shopButtonClick1
            // 
            this.shopButtonClick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shopButtonClick1.Location = new System.Drawing.Point(0, -6);
            this.shopButtonClick1.Name = "shopButtonClick1";
            this.shopButtonClick1.Size = new System.Drawing.Size(502, 322);
            this.shopButtonClick1.TabIndex = 6;
            this.shopButtonClick1.UseVisualStyleBackColor = true;
            this.shopButtonClick1.Click += new System.EventHandler(this.shopButtonClick1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(75, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(502, 316);
            this.button1.TabIndex = 6;
            this.button1.Text = "ShopButtonClick";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // RestaurantBox2
            // 
            this.RestaurantBox2.Controls.Add(this.label5);
            this.RestaurantBox2.Controls.Add(this.label6);
            this.RestaurantBox2.Controls.Add(this.pictureBox2);
            this.RestaurantBox2.Controls.Add(this.label7);
            this.RestaurantBox2.Controls.Add(this.label8);
            this.RestaurantBox2.Controls.Add(this.button2);
            this.RestaurantBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurantBox2.Location = new System.Drawing.Point(75, 544);
            this.RestaurantBox2.Name = "RestaurantBox2";
            this.RestaurantBox2.Size = new System.Drawing.Size(502, 316);
            this.RestaurantBox2.TabIndex = 7;
            this.RestaurantBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wetherspoons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 75);
            this.label6.TabIndex = 4;
            this.label6.Text = "Services offered:\r\nHot Food\r\nAlcoholic Beverages ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::UniEats_Alpha.Properties.Resources.SpoonsUni;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(248, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 224);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "Delivery Estimate:\r\n15-30 Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 50);
            this.label8.TabIndex = 1;
            this.label8.Text = "Delivery Charge: \r\n£0.99 - £3.49";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(502, 316);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Restraunts Available";
            // 
            // ViewRestaurants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniEats_Alpha.Properties.Resources.IphoneBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 1029);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RestaurantBox2);
            this.Controls.Add(this.RestaurantBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewRestaurants";
            this.RestaurantBox1.ResumeLayout(false);
            this.RestaurantBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RestaurantBox2.ResumeLayout(false);
            this.RestaurantBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RestaurantBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button shopButtonClick1;
        private System.Windows.Forms.GroupBox RestaurantBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}