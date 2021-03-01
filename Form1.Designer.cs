
namespace SemanticAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.TextBoxHTML = new System.Windows.Forms.RichTextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelHTML = new System.Windows.Forms.Label();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.TextBoxMeta = new System.Windows.Forms.RichTextBox();
            this.TextBoxText = new System.Windows.Forms.RichTextBox();
            this.labelMeta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 25);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(695, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // TextBoxHTML
            // 
            this.TextBoxHTML.Location = new System.Drawing.Point(12, 64);
            this.TextBoxHTML.Name = "TextBoxHTML";
            this.TextBoxHTML.Size = new System.Drawing.Size(776, 259);
            this.TextBoxHTML.TabIndex = 1;
            this.TextBoxHTML.Text = "";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 9);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 2;
            this.labelURL.Text = "URL";
            // 
            // labelHTML
            // 
            this.labelHTML.AutoSize = true;
            this.labelHTML.Location = new System.Drawing.Point(12, 48);
            this.labelHTML.Name = "labelHTML";
            this.labelHTML.Size = new System.Drawing.Size(37, 13);
            this.labelHTML.TabIndex = 3;
            this.labelHTML.Text = "HTML";
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(713, 23);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(75, 23);
            this.buttonAnalyze.TabIndex = 4;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(194, 326);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "Text";
            // 
            // TextBoxMeta
            // 
            this.TextBoxMeta.Location = new System.Drawing.Point(12, 342);
            this.TextBoxMeta.Name = "TextBoxMeta";
            this.TextBoxMeta.Size = new System.Drawing.Size(179, 96);
            this.TextBoxMeta.TabIndex = 6;
            this.TextBoxMeta.Text = "";
            // 
            // TextBoxText
            // 
            this.TextBoxText.Location = new System.Drawing.Point(197, 342);
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(591, 96);
            this.TextBoxText.TabIndex = 7;
            this.TextBoxText.Text = "";
            // 
            // labelMeta
            // 
            this.labelMeta.AutoSize = true;
            this.labelMeta.Location = new System.Drawing.Point(9, 326);
            this.labelMeta.Name = "labelMeta";
            this.labelMeta.Size = new System.Drawing.Size(31, 13);
            this.labelMeta.TabIndex = 8;
            this.labelMeta.Text = "Meta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMeta);
            this.Controls.Add(this.TextBoxText);
            this.Controls.Add(this.TextBoxMeta);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.labelHTML);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.TextBoxHTML);
            this.Controls.Add(this.textBoxURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.RichTextBox TextBoxHTML;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelHTML;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.RichTextBox TextBoxMeta;
        private System.Windows.Forms.RichTextBox TextBoxText;
        private System.Windows.Forms.Label labelMeta;
    }
}

