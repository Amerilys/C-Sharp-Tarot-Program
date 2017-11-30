namespace DynamicallyGeneratingFormControls
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
            this.btnDealCards = new System.Windows.Forms.Button();
            //this.btnCardMeanings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDealCards
            // 
            this.btnDealCards.Location = new System.Drawing.Point(405, 267);
            this.btnDealCards.Name = "btnDealCards";
            this.btnDealCards.Size = new System.Drawing.Size(75, 23);
            this.btnDealCards.TabIndex = 0;
            this.btnDealCards.Text = "Deal Cards";
            this.btnDealCards.UseVisualStyleBackColor = true;
            this.btnDealCards.Click += new System.EventHandler(this.btnDealCards_Click);
            // 
            // btnCardMeanings
            // 
            //this.btnCardMeanings.Location = new System.Drawing.Point(505, 267);
            //this.btnCardMeanings.Name = "btnCardMeanings";
            //this.btnCardMeanings.Size = new System.Drawing.Size(75, 23);
            //this.btnCardMeanings.TabIndex = 0;
            //this.btnCardMeanings.Text = "Card Meanings";
            //this.btnCardMeanings.UseVisualStyleBackColor = true;
            //this.btnCardMeanings.Click += new System.EventHandler(this.btnCardMeanings_Click);
            //
            // textBox
            //
           // this.textBox1.Location = new System.Drawing.Point(1200, 500);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 312);
            this.Controls.Add(this.btnDealCards);
            //this.Controls.Add(this.btnCardMeanings);
            this.Name = "Tarot Card Reading";
            this.Text = "Tarot Card Reading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDealCards;
        //private System.Windows.Forms.Button btnCardMeanings;
    }
}

